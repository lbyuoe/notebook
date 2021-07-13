using System;

namespace SomeNameSpace {
    namespace Nested {
        public class NestdNameSpaceClass {
            public static void SayHello() {
                Console.WriteLine("In Nested");
            }
        }
    }

    public class MyClass {
        static void Main() {
            Console.WriteLine("In SomeNameSpace");
            Nested.NestdNameSpaceClass.SayHello();
        }
    }
}