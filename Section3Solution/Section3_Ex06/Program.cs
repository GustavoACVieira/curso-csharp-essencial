using System;

namespace Section3_Ex06 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Primeira maneira");
            for (int i = 10; i <= 20; i += 2) {
                if (i == 16) {
                    continue;
                } else if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\nSegunda maneira");
            for (int i = 10; i <= 20; i++) {
                if (i == 16) {
                    continue;
                } else if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }

            int i2 = 10;
            Console.WriteLine("\nTerceira maneira");
            for ( ; ; ) {
                if (i2 == 20) {
                    Console.WriteLine(i2);
                    break;
                } else if (i2 == 16) {
                    i2++;
                    continue;
                } else if (i2 % 2 == 0) {
                    Console.WriteLine(i2);
                    i2++;
                }
                i2++;
            }

        }
    }
}