using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02_POO.model_02
{
    public class Vendedor : funcionario
    {
        private int comissao;
        public Vendedor(int RM, string nome, string cargo, int salario, string empresa, int comissao) : base(RM, nome, cargo, salario, empresa)
        {
            this.comissao = comissao;

        }

        public int GetComissao()
        {
            return comissao;
        }
        public void SetComissao(int comissao)
        {
            this.comissao = comissao;
        }

        public override void visualizar()
        {
            base.visualizar();

            Console.WriteLine("Comissão:" + this.comissao);
        }
    }
}
