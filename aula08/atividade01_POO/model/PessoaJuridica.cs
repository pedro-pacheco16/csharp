using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01_POO.model
{
    public class PessoaJuridica : Cliente
    {
        private int ImpostoCorporativo;
        public PessoaJuridica(int id, string nome, string Doc, int telefone, string endereco, int ImpostoCorporativo) : base(id, nome, Doc, telefone, endereco)
        {
            this.ImpostoCorporativo = ImpostoCorporativo;
        }

        public int GetImpostoCorporativo()
        {
            return ImpostoCorporativo;
        }
        
        public void SetImpostoCorporativo(int ImpostoCorporativo)
        {
            this.ImpostoCorporativo = ImpostoCorporativo;
        }

        public override void visualizar()
        {
            base.visualizar();

            Console.WriteLine($"Imposto Corporativo: {ImpostoCorporativo}");
        }
    }
}
