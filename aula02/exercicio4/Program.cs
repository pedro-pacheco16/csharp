using System.Runtime.InteropServices;

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4,diferenca;
            Console.WriteLine("digite o n1:");
            n1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite o n2:");
            n2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite o n3:");
            n3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite n4:");
            n4 = Convert.ToSingle(Console.ReadLine());

            diferenca= (n1 * n2) - (n3 * n4);

            Console.WriteLine("calculo = " + Math.Round(diferenca, 2));
            
        }
    }
}