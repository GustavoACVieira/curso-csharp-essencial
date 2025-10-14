namespace Section9_Ex03 {
    internal class Program {
        public delegate bool Filtro(int num);

        static void Main(string[] args) {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            Filtro f1 = delegate (int num) {
                return num % 2 == 0;
            };

            Filtro f2 = (int num) => num > 3;

            var resultadoPar = list.FindAll(num => f1(num));
            var resultadoMaior3 = list.FindAll(num => f2(num));

            Console.WriteLine("Pares: " + string.Join(", ", resultadoPar));
            Console.WriteLine("Maiores que 3: " + string.Join(", ", resultadoMaior3));
        }
    }
}
