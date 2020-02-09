namespace DipDemo3
{
    public static class ReaderFactory
    {
        public static IReader GetReader(string readerType)
        {
            if (string.IsNullOrEmpty(readerType))
            {
                return null;
            }

            switch (readerType)
            {
                case "NewsPaper":
                    return new Paper();
                case "Book":
                    return new Book();
                default:
                    return null;
            }
        }
    }
}
