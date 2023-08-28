using System.Runtime.Serialization;

namespace exercicio06_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
           float media = 0,numero,soma = 0,total = 0;

            do
            {
                Console.WriteLine("Digite um número:");
                numero = Convert.ToSingle(Console.ReadLine());

                if (numero % 3 == 0 && numero != 0)
                {
                    soma += numero;
                    total++;
                }

            } while (numero != 0);

            media = soma / total;

            Console.WriteLine($"Média dos multiplos de 3: {media:F2}");

        }
    }
}