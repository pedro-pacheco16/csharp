using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivRMade02_POO.model_02
{
    public class funcionario
    {
        private int RM;
        private string nome = string.Empty;
        private string cargo = string.Empty;
        private decimal salario;
        private string empresa = string.Empty;

        public funcionario(int RM, string nome, string cargo, int salario, string empresa)
        {
            this.RM = RM;
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
            this.empresa = empresa;
        }
        public int GetRM()
        {
            return RM;
        }
        public void SetRM(int RM)
        {
            this.RM = RM;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string Getcargo()
        {
            return cargo;
        }

        public void Setcargo(string cargo)
        {
            this.cargo = cargo;
        }

        public decimal Getsalario()
        {
            return salario;
        }

        public void Setsalario(decimal salario)
        {
            this.salario = salario;
        }

        public string Getempresa()
        {
            return empresa;
        }

        public void Setempresa(string empresa)
        {
            this.empresa = empresa;
        }

        public void visualizar()
        {
            Console.WriteLine("\n\n*********************************************************************");
            Console.WriteLine("Dados do Funcionário:");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Numero do RM: " + this.RM);
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("cargo: " + cargo);
            Console.WriteLine("salario: " + this.salario);
            Console.WriteLine("empresa: " + this.empresa);

        }
    }
}
