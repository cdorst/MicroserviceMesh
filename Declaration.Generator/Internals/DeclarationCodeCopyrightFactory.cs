using Microsoft.Extensions.Configuration;
using static System.String;

namespace Declaration.Generator.Internals
{
    internal static class DeclarationCodeCopyrightFactory
    {
        private const string Copyright = nameof(Copyright);
        private const string Default = "Christopher Dorst";

        public static string CopyrightValue(in IConfigurationRoot configuration) => Format(configuration[Copyright]);

        private static string Format(in string copyright)
            => Concat(Copyright, " © ", IsNullOrWhiteSpace(copyright) ? Default : copyright);
    }
}
