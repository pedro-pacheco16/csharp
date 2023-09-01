using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01_POO.model
{
    public class PessoaFisica : Cliente
    {

        private int ImpostoDeRenda;
       
        public PessoaFisica(int id, string nome, string Doc, int telefone, string endereco,int ImpostoDeRenda) : base(id, nome, Doc, telefone, endereco)
        {
            this.ImpostoDeRenda = ImpostoDeRenda;
        }
        public int GetImpostoDeRenda()
        {
            return ImpostoDeRenda;
        }

        public void SetImpostoDeRenda(int ImpostoDeRenda)
        {
            this.ImpostoDeRenda = ImpostoDeRenda;
        }

        public override void visualizar()
        {
            base.visualizar();

            Console.WriteLine($"Imposto de renda: {ImpostoDeRenda }");
        }


    }
}
