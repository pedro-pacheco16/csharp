using System.Xml.Schema;

namespace Exer02_vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            string Impares = "", pares = "";
           float soma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um número:");
                vetor[i] = Convert.ToInt32(Console.ReadLine());

                if(i % 2 != 0)
                {
                    Impares += vetor[i] + " ";
                }
                if (vetor[i] % 2 == 0)
                {
                    pares += vetor[i] + " ";
                }

                soma += vetor[i];
                
            }

            Console.WriteLine($"\nElementos de índices impares: {Impares}");
            Console.WriteLine($"\nElementos Pares: {pares}");
            Console.WriteLine($"\nsoma: {soma}");
            Console.WriteLine($"média: {soma / vetor.Length:F2}");

        }
    }
}