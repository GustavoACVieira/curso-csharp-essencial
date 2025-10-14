namespace Section9_Ex12 {
    internal class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>() { "Maria", "Antonio", "Andréia", "Everton", "João", "Ernesto", "Bernardo" };
            Func<string, bool> filtro = str => str.ToLower().StartsWith('a') || str.ToLower().StartsWith('e') || str.ToLower().StartsWith('i') ||
            str.ToLower().StartsWith('o') || str.ToLower().StartsWith('u');

            foreach (string l in list) {
                if (filtro(l))
                    Console.WriteLine(l);
            }
        }
    }
}
