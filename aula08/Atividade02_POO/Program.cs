using AtivRMade02_POO.model_02;

namespace Atividade02_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            funcionario funcionario1 = new funcionario(1049, "Pedro Pacheco", "Mecânico de Usinagem", 10000, "Biscoitos Bela Vista");

            funcionario1.visualizar();

            funcionario funcionario2 = new funcionario(1050, "Carlos", "Eletricista", 15000, "Biscoitos Bela Vista");

            funcionario2.visualizar();
        }
    }
}