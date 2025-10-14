namespace Section5_ArraysMultidimensionais1 {
    internal class Program {
        static void Main(string[] args) {
            int[,] a;

            a = new int[2, 2];

            a[0, 0] = 10;
            a[0, 1] = 11;
            a[1, 0] = 12;
            a[1, 1] = 13;
            Console.WriteLine("\nArray a");
            Console.WriteLine(a[0, 0]);
            Console.WriteLine(a[0, 1]);
            Console.WriteLine(a[1, 0]);
            Console.WriteLine(a[1, 1]);

            //int[,] b = new int[2, 2] { { 20, 30 }, { 40, 50 } };
            Console.WriteLine("\nArray b");
            int[,] b = { { 20, 30 }, { 40, 50 } };

            Console.WriteLine(b[0, 0]);
            Console.WriteLine(b[0, 1]);
            Console.WriteLine(b[1, 0]);
            Console.WriteLine(b[1, 1]);
        }
    }
}
