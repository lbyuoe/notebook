using System;

// 声明委托，声明固定签名的函数指针
delegate int Converter(int i);

namespace Lambda {
    class Program {
        static void Main(string[] args) {
            // 实例化委托，创建函数指针变量，并赋值到将要调用的函数
            Converter sqr = a;
            // 调用委托实例，通过函数指针调用函数
            Console.WriteLine(sqr(3));  // 9
        }

        // 定义将要调用的函数
        static int a(int x) {
            return x * x;
        }
    }
}
