using static System.DateTimeOffset;
using static System.Environment;
using static System.String;

namespace Declaration.Generator.Internals
{
    internal static class DeclarationCodeCopyrightFactory
    {
        private const string Copyright = nameof(Copyright);
        private static readonly string _copyrightEnvironmentValue = GetEnvironmentVariable(Concat("CodeGenerator_", Copyright));
        private static readonly string _copyrightYear = UtcNow.Year.ToString();

        public static readonly string CopyrightValue = Concat(Copyright, " © ", _copyrightYear,
            IsNullOrWhiteSpace(_copyrightEnvironmentValue) ? "Christopher Dorst" : _copyrightEnvironmentValue);
    }
}
