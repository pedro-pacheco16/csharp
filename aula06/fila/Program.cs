namespace fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Breno");
            fila.Enqueue("Eduardo");
            fila.Enqueue("julia");
            fila.Enqueue("Leonardo");
            fila.Enqueue("Gaspar");

            fila.Dequeue();
            foreach(var nome in fila)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("Quem é o primeiro da fila?" + fila.Peek());

            Console.WriteLine("O Gaspar entrou na fila? " + fila.Contains("gaspar"));

            Console.WriteLine("numero de pessoas na fila: " + fila.Count());

        }
    }
}