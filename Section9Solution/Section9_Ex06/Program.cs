namespace Section9_Ex06 {
    internal class Program {
        static void Main(string[] args) {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Action<int> actPares = x => { 
                if (x % 2 == 0) {
                    Console.WriteLine(x);
                }
            };

            list.ForEach(actPares);

        }
    }
}
