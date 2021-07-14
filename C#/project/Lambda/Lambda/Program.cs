using System;

namespace Lambda {
    class Program {
        static void Main(string[] args) {
            
        }

        Func<string> getUserInput =
            () => {
                string input;
                do {
                    input = Console.ReadLine();
                } while (input.Trim().Length == 0);
                return input;
            };
    }
}
