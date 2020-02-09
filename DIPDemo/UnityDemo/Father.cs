using System;

namespace UnityDemo
{
    public class Father
    {
        public IReader Reader { get; set; }

        /// <summary>
        /// 构造函数的参数是IReader接口类型
        /// </summary>
        /// <param name="reader"></param>
        public Father(IReader reader)
        {
            Reader = reader;
        }

        public void Read()
        {
            Console.WriteLine("爸爸开始给孩子讲故事了");
            Console.WriteLine(Reader.GetContent());
        }
    }
}
