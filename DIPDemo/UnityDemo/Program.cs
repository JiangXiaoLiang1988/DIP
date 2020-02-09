using System;
using Unity;

namespace UnityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建容器
            var container = new UnityContainer();

            // 扫描程序集、配置文件
            // 在容器里面注册接口和实现类，创建依赖关系
            container.RegisterType<IReader, Book>();

            // 在容器里面注册Father
            container.RegisterType<Father>();

            // 从容器里拿出要使用的类，容器会自行创建father对
            // 还会从容器里去拿到他所依赖的对象，并且注入进来
            // 
            var father = container.Resolve<Father>();

            // 调用方法
            father.Read();
            Console.ReadKey();
        }
    }
}
