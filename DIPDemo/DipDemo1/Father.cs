using System;

namespace DipDemo1
{
    public class Father
    {
        public void Read()
        {
            // 读书
            // Book book = new Book();
            //Console.WriteLine("爸爸开始给孩子讲故事了");
            //Console.WriteLine(book.GetContent());

            // 报纸
            NewsPaper paper = new NewsPaper();
            Console.WriteLine("爸爸开始给孩子讲新闻");
            Console.WriteLine(paper.GetContent());
        }
    }
}
