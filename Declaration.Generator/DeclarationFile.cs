namespace Declaration.Generator
{
    public readonly ref struct DeclarationFile
    {
        public readonly string Contents;
        public readonly string[] PathParts;

        public DeclarationFile(in string contents, in string[] pathParts)
        {
            Contents = contents;
            PathParts = pathParts;
        }
    }
}
