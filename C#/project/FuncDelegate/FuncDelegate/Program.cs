using System;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2 {
    class Program {
        public static void Main(string[] args) {
            int[] items = { 1, 3, 2 };

            // 委托实例化
            Func<int, int, bool> compare = easy;

            BubbleSort(items, easy);
            for (int i = 0; i <= 2; i++) {
                Console.WriteLine(items[i]);
            }
        }

        public static bool easy(int a, int b) {
            if (a < b) {
                return false;
            } else {
                return true;
            }
        }

        public enum SortType {
            Ascending,
            Descending
        }

        // func前面是输入类型，最后一个是输出类型
        public static void BubbleSort(int[] items, Func<int, int, bool> compare) {
            if (compare == null) {
                throw new ArgumentNullException(nameof(compare));
            }
            int temp;

            for (int i = items.Length - 1; i >= 0; i--) {
                for (int j = 1;j <= i;j++) {
                    if (compare(items[j - 1], items[j])) {
                        temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }
    }
}
