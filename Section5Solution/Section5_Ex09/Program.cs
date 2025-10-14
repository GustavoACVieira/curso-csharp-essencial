namespace Section5_Ex09 {
    internal class Program {
        static void Main(string[] args) {
            ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null);
        }

        public static void ProcessaObjetos(params object[] args0) {
            try {
                if (args0 != null) {
                    foreach (var item in args0) {
                        Console.WriteLine($"Tipo da variavel: {item.GetType()} - Valor: {item}");
                    }
                }
            } catch (Exception e) {
                Console.WriteLine($"Erro: << {e.Message} >> \nDescrição: {e.Source}");
            }
        }
    }
}
