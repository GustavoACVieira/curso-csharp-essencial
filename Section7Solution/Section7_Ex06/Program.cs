namespace Section7_Ex06 {
    internal class Program {
        static void Main(string[] args) {
            Queue<string> filaImpressao = new Queue<string>();

            filaImpressao.Enqueue("Teste1.pdf");
            filaImpressao.Enqueue("Teste2.pdf");
            filaImpressao.Enqueue("Teste3.pdf");
            filaImpressao.Enqueue("Manual1.pdf");
            filaImpressao.Enqueue("Manual2.pdf");
            filaImpressao.Enqueue("Manual3.pdf");
            filaImpressao.Enqueue("Mesa1.pdf");
            filaImpressao.Enqueue("Mesa2.pdf");

            for (int i = filaImpressao.Count; i > 0; i--) {
                if (filaImpressao.Count == 0) {
                    Console.WriteLine("Fila Vazia!");
                } else {
                    Console.WriteLine($"\nO Documento {filaImpressao.Dequeue()} está sendo impresso");
                    Console.WriteLine("Imprimindo...");
                    Thread.Sleep(new Random().Next(1000, 5000));
                    Console.WriteLine("Impresso com sucesso!");
                }
            }
        }
    }
}
