using System.Numerics;
using System.Runtime.ConstrainedExecution;

namespace transportes
{
    public class Program
    {
        static void Main(string[] args)
        {
            transporte t1 = new transporte(5);

            t1.Visualizar();

            terrestre t2 = new terrestre(4, 4, 100);
            t2.Visualizar();

            automovel a1 = new automovel(10, 10, 280,"preto", 1, "fvww-6543", 7);

            a1.Visualizar();
        }
    }
}