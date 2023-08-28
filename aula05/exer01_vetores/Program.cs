using System.Numerics;

namespace exer01_vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int num = 0;

     
            Console.WriteLine($"Digite um número:");
            num = Convert.ToInt32(Console.ReadLine());

            int posicao = Array.IndexOf(vetor, num);

            if (posicao >= 0)
                {  
                    Console.WriteLine($"\na posição do numero é:" + posicao);
                }
                else
                {
                    Console.WriteLine($"\nNão foi encontrado!");
                }
            }
        }
    }
