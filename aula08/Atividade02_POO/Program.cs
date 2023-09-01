using Atividade02_POO.model_02;

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

            Gerente G1 = new Gerente(500, "Leandro", "Gerente Comercial", 5000, "Biscoistos Bela Vista", "SuperMercados Carrefour");

            G1.visualizar();

            Gerente G2 = new Gerente(550, "Marcos", "Gerente Comercial", 6000, "Biscoistos Bela Vista", "Supermercados extra");

            G2.visualizar();

            Vendedor v1 = new Vendedor(300, "Paulo", "vendedor 1", 2500, "Biscoitos Bela Vista", 500);

            v1.visualizar();

            Vendedor v2 = new Vendedor(301, "vitória", "vendedor 2 ", 2550, "Biscoistos Bela Vista", 550);

            v2.visualizar();
        }
    }
}