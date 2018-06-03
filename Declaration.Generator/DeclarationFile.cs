namespace Declaration.Generator
{
    public readonly struct DeclarationFile
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
