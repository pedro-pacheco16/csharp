using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportes
{
   public class transporte
    {
        private int capacidade;

        public transporte(int capacidade)
        {
            this.capacidade = capacidade;
        }

        public int GetCapacidade()
        {
            return this.capacidade;
        }
        public void SetCapacidade(int capacidade)
        {
            this.capacidade = capacidade;
        }

        public virtual void Visualizar() //virtual é uma função que quer dizer que o método pode ser subestrito em outra classe
        {
            Console.WriteLine("\n\n************************************************************");
            Console.WriteLine("                Dados do Meio de Transporte:                    ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Capacidade de passageiros: " + this.capacidade);

        }
    }
}
