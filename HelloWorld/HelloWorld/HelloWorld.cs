// using关键字用于在程序中包含System命名空间
using System;

// namespace声明，一个namespace里包含了一系列的类
namespace HelloWorldApplication {
    // class声明，类里包含了程序使用的数据和方法声明
    class HelloWorld {
        // Main方法是所有C#程序的入口点
        static void Main(string[] args) {
            Console.WriteLine("Hello World");
            // 针对VS.NET用户，这使得程序会等待一个按键的动作，防止程序从Visual Studio .NET启动时屏幕会快速运行并关闭
            Console.ReadKey();
        }
    }
}