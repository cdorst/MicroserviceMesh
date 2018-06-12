using Common.Extensions.Memory;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data.SqlClient;
using static System.Activator;
using static System.String;

namespace Shared.Services.Startups
{
    public class SaveOperationStartup<TEntity, TKey>
        where TEntity : IEntity<TEntity, TKey>
        where TKey : unmanaged, IEquatable<TKey>
    {
        private readonly byte _bufferSize;
        private readonly string _cacheKeyPrefix;
        private readonly string _commandPrefix;
        private readonly IConfiguration _configuration;
        private readonly TKey _defaultKey = default;
        private readonly byte _keySize;
        private readonly bool _saveBlob;
        private readonly string _sqlConnectionString;
        private readonly TEntity _type;

        public SaveOperationStartup(IConfiguration configuration)
        {
            _configuration = configuration;
            _sqlConnectionString = configuration.GetConnectionString("SqlServer");
            _type = CreateInstance<TEntity>();
            // TODO assign-to remaining `private readonly` fields
        }

        public void ConfigureServices(IServiceCollection services)
            => services
                .AddDistributedRedisCache(options =>
                {
                    options.Configuration = _configuration["Redis:Configuration"];
                    options.InstanceName = _configuration["Redis:InstanceName"];
                })
                .AddRouting();

        public void Configure(IApplicationBuilder app, IDistributedCache cache)
            => app.UseRouter(routes =>
                routes.MapPost("/", async context =>
                {
                    var bytes = new byte[_bufferSize];
                    await context.Request.Body.ReadAsync(bytes, 0, _bufferSize);

                    // Call SQL stored procedure (to assign-new or get-existing key for value bytes)
                    var key = default(TKey);
                    using (var connection = new SqlConnection(_sqlConnectionString))
                    using (var command = new SqlCommand(Concat(_commandPrefix, _type.ToSqlSaveProcedureParameters(in bytes)), connection))
                    {
                        await connection.OpenAsync();
                        key = (TKey)(await command.ExecuteScalarAsync());
                    }

                    try
                    {
                        // Save Redis cache entry (to prevent SQL-db reads for cached items)
                        await cache.SetAsync(Concat(_cacheKeyPrefix, key.ToString()), bytes);
                    }
                    catch (Exception)
                    {
                    }

                    // TODO Save Azure Table entry (to permenently prevent SQL-db reads for non-updatable data)
                    if (_saveBlob)
                    {
                        // TODO Save Azure Blob (for client to access via CDN)
                    }
                    // TODO decide: save to Redis & Azure Storage here or in Azure Function (triggered by EventGrid app-event fired here)?

                    var response = context.Response;
                    response.StatusCode = StatusCodes.Status200OK;
                    response.ContentLength = _keySize;
                    await response.Body.WriteAsync(Bytes(in key).ToArray(), 0, _keySize);
                }));

        private static ReadOnlySpan<byte> Bytes(in TKey key)
        {
            if (key is Int64 int64) return int64.ToSpan();
            if (key is Int32 int32) return int32.ToSpan();
            if (key is Int16 int16) return int16.ToSpan();
            if (key is Byte @byte) return new[] { @byte };
            throw new ArgumentOutOfRangeException("Unexpected key type");
        }
    }
}
