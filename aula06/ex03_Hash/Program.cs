namespace ex03_Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> valores = new HashSet<int>();

            Console.WriteLine("Digite 10 números: ");

            for (int i = 1; i <= 10; i++)
            {
               valores.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("\n");

            foreach (var val in valores)
            {
                Console.WriteLine(val);
            }
        }
    }
}