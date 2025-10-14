namespace Section7_Ex05 {
    internal class Program {
        static void Main(string[] args) {
            Stack<char> parentesesAbertos = new Stack<char>();

            Console.WriteLine("Informe a expressão matemática: ");
            char[] expressaoMatC = Console.ReadLine().ToCharArray();

            for (int i = 0; i < expressaoMatC.Length; i++) {
                char c = expressaoMatC[i];
                if (c.Equals('(') || c.Equals('{') || c.Equals('[')) {
                    parentesesAbertos.Push(c);
                } else if (c.Equals(')') || c.Equals('}') || c.Equals(']')) {
                    char topo = parentesesAbertos.Peek();
                    if (parentesesAbertos.Count != 0 && (topo == '(' && c == ')') || (topo == '{' && c == '}') || (topo == '[' && c == ']')) {
                        parentesesAbertos.Pop();
                    }
                }
            }

            if (parentesesAbertos.Count == 0) 
                Console.WriteLine("A expressão possui parênteses balanceados!");
            else
                Console.WriteLine("A expressão não possui parênteses balanceados!");
        }
    }
}
