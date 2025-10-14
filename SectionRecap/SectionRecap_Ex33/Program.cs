namespace SectionRecap_Ex33 {
    internal class Program {
        static void Main(string[] args) {
            Pedido pedido = new Pedido();
            pedido.PedidoConcluido += NotificarConclusao;

            pedido.Concluir("Notebook", 3500.00);
        }

        static void NotificarConclusao(object? sender, PedidoEventArgs e) {
            Console.WriteLine("Pedido concluido: " + e.Produto + " - Valor: R$" + e.Valor);
        }
    }
}
