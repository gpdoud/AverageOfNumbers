using System;

namespace AverageOfNumbers {
    class Program {
        static void Main(string[] args) {
            int[] ints = {
                754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
                187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
                460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
                690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
                435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            };

            var total = 0;
            var count = 0;
            foreach(var nbr in ints) {
                total += nbr;
                count++;
            }
            var avg = total / count;
            Console.WriteLine($"The average is {avg}");
        }
    }
}
