namespace exercicio02_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPares = 0, numImpares = 0, numeros = 10;

            for(int i = 1; i <= numeros; i++)
            {
                Console.WriteLine("Digite os numeros:");
                numeros = Convert.ToInt32(Console.ReadLine());

                if(numeros % 2 == 0)
                {
                    numPares++;
                }
                else
                {
                    numImpares++;
                }

            }

            Console.WriteLine($"Total de números Pares: {numPares}");
            Console.WriteLine($"Total de números Pares: {numImpares}");
        }
    }
}