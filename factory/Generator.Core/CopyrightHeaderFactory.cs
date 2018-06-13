using Microsoft.Extensions.Configuration;
using static System.DateTime;
using static System.String;

namespace Generator.Core
{
    public static class CopyrightHeaderFactory
    {
        private const string Copyright = nameof(Copyright);
        private static readonly string Default = UtcNow.Year.ToString();

        public static string CopyrightValue(in IConfigurationRoot configuration)
            => Format(configuration[Copyright]);

        private static string Format(in string copyright)
            => Concat(Copyright, " © ", IsNullOrWhiteSpace(copyright) ? Default : copyright);
    }
}
