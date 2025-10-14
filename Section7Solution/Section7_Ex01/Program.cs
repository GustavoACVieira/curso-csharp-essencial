namespace Section7_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            ClasseGenerica<int> clgInt = new ClasseGenerica<int>();

            for (int i = 0; i < 5; i++) {
                clgInt.Adicionar(i);
            }

            for (int i = 0; i < 5; i++) {
                Console.WriteLine(clgInt[i]);
            }
        }
    }
}
