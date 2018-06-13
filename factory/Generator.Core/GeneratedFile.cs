namespace Generator.Core
{
    public readonly struct GeneratedFile
    {
        public readonly string Contents;
        public readonly string[] PathParts;

        public GeneratedFile(in string contents, params string[] pathParts)
        {
            Contents = contents;
            PathParts = pathParts;
        }
    }
}
