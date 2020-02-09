using System;

namespace DipDemo2
{
    public class Father
    {
        private IReader Reader { get; set; }

        public Father(string readerName)
        {
            // 这里依赖于抽象
            Reader = ReaderFactory.GetReader(readerName);
        }

        public void Read()
        {
            Console.WriteLine("爸爸开始给孩子讲故事了");
            Console.WriteLine(Reader.GetContent());
        }
    }
}
