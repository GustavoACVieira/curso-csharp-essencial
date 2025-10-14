namespace Section8_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            string nome = null;
            int idade = 0;

			try {
                Console.WriteLine("Informe seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Informe sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade < 0) {
                    throw new ArgumentException("A idade não pode ser negativa", "idade");
                } else if (idade == 0) {
                    throw new NotImplementedException("A idade ainda não foi definida");
                } else if (string.IsNullOrEmpty(nome)) {
                    throw new NullReferenceException("O nome não pode ser nulo nem vazio");
                }

            } catch (ArgumentException ex) {
                Console.WriteLine("Erro: " + ex.Message);
            } catch (NotImplementedException ex) {
                Console.WriteLine("Erro: " + ex.Message);
            } catch (NullReferenceException ex) {
                Console.WriteLine("Erro: " + ex.Message);
            } catch (Exception ex) {
                Console.WriteLine("Erro: " + ex.Message);
            } finally {
                Console.WriteLine("Fim do programa");
            }
        }
    }
}
