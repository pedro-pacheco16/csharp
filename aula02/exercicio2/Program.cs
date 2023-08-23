using System;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3,nota4,media;
            Console.WriteLine("digite o nota1:");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite o nota2:");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite o nota3:");
            nota3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite o nota4:");
            nota4 = Convert.ToSingle(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4)/4;

            Console.WriteLine("media final = " + Math.Round(media, 2));
        }
    }
}