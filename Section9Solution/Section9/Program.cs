namespace Section9
{
    internal class Program
    {
        public delegate void MeuDelegate(string mensagem);

        public static void MeuMetodo(string msg) {
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            //Formas de Declarar
            //1 opção
            MeuDelegate del1 = new MeuDelegate(MeuMetodo);

            //2 opção
            MeuDelegate del2 = MeuMetodo;

            //3 opção
            MeuDelegate del3 = (msg) => Console.WriteLine(msg);

            //Formas de Invocar
            //1 opção
            del1.Invoke("Minha Mensagem");

            //2 opção
            del2("Minha Mensagem");

            //3 opção
            del3("Minha Mensagem");
        }
    }
}
