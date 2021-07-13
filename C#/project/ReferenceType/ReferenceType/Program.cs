/**
 * 引用类型不包括存储在变量中的实际数据，单他们包含对变量的引用。
 * 内置的引用类型有：object、dynamic、string
 * */

using System;

namespace ReferenceType {
    class Program {
        static void Main(string[] args) {
            // object是所有数据类型的终极基类，可以被分配任何其他类型的值，但是在分配值之前，需要先进行类型转换。
            // 当一个值类型转换为对象类型时，则被称为装箱；当一个对象类型转换为值类型时，则被称为拆箱。
            object obj;
            obj = 100;

            // 可以存储任何类型的在动态数据类型变量中。这些变量的类型检查是在运行时发生的。
            // 动态类型和对象类型相似，但对象类型变量的类型检查是在编译时发生的，而动态型变量的类型检查是在运行时发生的。
            dynamic d = 20;

            // 字符串类型可以给变量分配任何字符串值，是从对象类型中派生的。
            // 字符串类型的值可以通过两种形式进行分配：引号和@引号。
            String str1 = "runoob.com";
            String str2 = @"runoob.com";

            // @表示其后的字符串是个“逐字字符串”（verbatim string）
            // 对于逐字字符串字面变量，转义字符会失效，这在表示文件路径时很方便。
            string str3 = @"C:/Test.txt";
            // 逐字字符串能跨越数行，这数行内的空白字符都保留在字符串里，这样便能允许存储和生成带有格式的文本块。
            string str4 = @"Line1
Line2
Line3";
            // 如果要在逐字字符串中包含双引号，只需再加一个双引号即可
            string str5 = @"""Great"" Said Eric Chan";

            Console.WriteLine("{0}", str1);
            Console.WriteLine("{0}", str2);
            Console.WriteLine("{0}", str3);
            Console.WriteLine("{0}", str4);
            Console.WriteLine("{0}", str5);

        }
    }
}
