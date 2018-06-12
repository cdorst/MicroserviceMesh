using Microsoft.AspNetCore.Hosting;
using Shared.Services.Startups;
using System;
using static Microsoft.AspNetCore.WebHost;

namespace Shared.Services
{
    public static class EntryPoint
    {
        public static void Service<TEntity, TKey>(in Operation operation, in string[] args = default)
            where TEntity : IEntity<TEntity, TKey>
            where TKey : unmanaged, IEquatable<TKey>
        {
            switch (operation)
            {
                case Operation.Save:
                    Run<SaveOperationStartup<TEntity, TKey>>(in args);
                    break;
                default:
                    throw new NotImplementedException(nameof(operation));
            }
        }

        private static void Run<TStartup>(in string[] args)
            where TStartup : class
            => CreateDefaultBuilder(args)
                .UseStartup<TStartup>()
                .Build()
                .Run();
    }
}
