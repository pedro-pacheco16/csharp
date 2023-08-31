using atividade01_POO.model;

namespace atividade01_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(359, "Pedro Pacheco","095.578.188-09", 988270656, "Rua São joão, 45 - São Paulo");

            c1.visualizar();

            Cliente c2 = new Cliente(400, "Luiza", "296.879.199-10", 978371668, "Rua Tiradentes , 50 - Rio de Janeiro");

            c2.visualizar();
        }
    }
}