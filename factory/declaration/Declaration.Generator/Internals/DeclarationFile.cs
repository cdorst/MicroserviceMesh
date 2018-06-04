namespace Declaration.Generator.Internals
{
    public readonly struct DeclarationFile
    {
        public readonly string Contents;
        public readonly string[] PathParts;

        public DeclarationFile(in string contents, params string[] pathParts)
        {
            Contents = contents;
            PathParts = pathParts;
        }
    }
}
