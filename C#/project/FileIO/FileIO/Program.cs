using System;
using System.IO;

namespace FileIO {
    class Program {
        static void Main(string[] args) {
            FileStream F = new FileStream("test.txt", FileMode.Open, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++) {
                F.WriteByte((byte)i);
            }
            F.Position = 0;
            for (int i = 0; i <= 20; i++) {
                Console.WriteLine(F.ReadByte() + "");
            }
            F.Close();
            Console.ReadKey();
        }
    }
}
