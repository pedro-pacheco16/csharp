namespace pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string>pilha= new Stack<string>();

           pilha.Push("Breno");
           pilha.Push("Eduardo");
           pilha.Push("julia");
           pilha.Push("Leonardo");
           pilha.Push("Gaspar");

           pilha.Pop();
            foreach (var nome in pilha)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("Quem é o primeiro dapilha?" +pilha.Peek());

            Console.WriteLine("O Gaspar entrou napilha? " +pilha.Contains("gaspar"));

            Console.WriteLine("numero de pessoas napilha: " +pilha.Count());
        }
    }
}