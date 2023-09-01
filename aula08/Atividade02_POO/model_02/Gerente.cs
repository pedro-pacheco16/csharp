using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02_POO.model_02
{
    public class Gerente : funcionario
    {
        private string lojaMatriz;

        public Gerente(int RM, string nome, string cargo, int salario, string empresa,string lojaMatriz) : base(RM, nome, cargo, salario, empresa)
        {
            this.lojaMatriz = lojaMatriz;

        }

        public string GetlojaMatriz()
        {
            return lojaMatriz;
        }
        public void SetlojaMatriz(string lojaMatriz)
        {
            this.lojaMatriz = lojaMatriz;
        }
        public override void visualizar()
        {
            base.visualizar();

            Console.WriteLine("Loja Matriz:" + this.lojaMatriz);
        }
    }
}
