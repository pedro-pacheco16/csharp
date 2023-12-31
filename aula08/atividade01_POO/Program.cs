﻿using atividade01_POO.model;

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

            PessoaFisica Pf1 = new PessoaFisica(2, "josé", "234.546.299 - 05", 932381779, "Rua Lagoa da Prata", 700);

            Pf1.visualizar();

            PessoaFisica Pf2 = new PessoaFisica(2, "Carlos", "500.459.300 - 20 ", 93456780, "Rua Antônio da Silva", 800);

            Pf2.visualizar();

            PessoaJuridica Pj1 = new PessoaJuridica(1, "Marta", "345.567.567 -08", 908765432, "Rua trimundial", 10000);

            Pj1.visualizar();

            PessoaJuridica Pj2 = new PessoaJuridica(1, "Paula", "355.577.587 -07", 918775482, "Rua javascript", 20000);

            Pj2.visualizar();
        }
    }
}