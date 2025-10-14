namespace Section8_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            string texto = null;

            try {
                Console.WriteLine("Informe um valor do tipo string: ");
                texto = Console.ReadLine();

                if (texto == null ) {
                    throw new ArgumentNullException("texto", "O texto nao pode ser null");
                } else if (string.IsNullOrWhiteSpace(texto)) {
                    throw new ArgumentException("O texto não pode estar vazia", "texto");
                } else {
                    Console.WriteLine("Texto: " + texto);
                }
			} catch (ArgumentNullException ex) {
                Console.WriteLine("Erro: " + ex.Message);
			} catch (ArgumentException ex) {
                Console.WriteLine("Erro: " + ex.Message);
            } catch (Exception ex) {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
