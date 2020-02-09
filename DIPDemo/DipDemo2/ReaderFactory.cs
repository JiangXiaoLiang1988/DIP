namespace DipDemo2
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
                    return new NewsPaper();
                case "Book":
                    return new Book();
                default:
                    return null;
            }
        }
    }
}
