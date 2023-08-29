namespace exercio01_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cores = new List<string>();

            Console.WriteLine("Digite 5 cores: ");

            for (int i = 1; i <= 5; i++)
            {
                cores.Add(Console.ReadLine());
            }

            Console.WriteLine("\n");

            foreach(var cor in cores)
            {
                Console.WriteLine(cor);
            }

            Console.WriteLine("\n");

            cores.Sort();

            foreach (var cor in cores)
            {
                Console.WriteLine(cor);
            }
        }
        
    }    

}
