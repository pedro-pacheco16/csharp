using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01_POO.model
{
    public class Cliente
    {
        private int id;
        private string nome = string.Empty;
        private string Doc = string.Empty;
        private int telefone;
        private string endereco = string.Empty;

        public Cliente(int id, string nome, string Doc, int telefone, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.Doc = Doc;
            this.telefone = telefone;
            this.endereco = endereco;
        }
        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
 
        public string GetNome()
        {
            return nome;
        } 

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetDoc()
        {
            return Doc;
        }

        public void SetDoc(string Doc)
        {   

            this.Doc = Doc;
        }

        public int GetTelefone()
        {
            return telefone;
        }

        public void SetTelefone(int telefone)
        {
          
            this.telefone = telefone;
        }

        public string GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public virtual void visualizar()
        {
            string TipoCliente = string.Empty;
            switch (this.id)
            {
                case 1:
                    TipoCliente = "Pessoa Juridica\nCNPJ do Cliente: " + this.Doc;
                break;

                case 2:
                    TipoCliente = "Pessoa fisica\nCPF do Cliente: " + this.Doc;
                break;
            }


            Console.WriteLine("\n\n*********************************************************************");
            Console.WriteLine("Dados do Cliente:");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine($"Tipo do Cliente: {TipoCliente}");
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Telefone: " + this.telefone);
            Console.WriteLine("endereco: " + this.endereco);
            

        }
    }
        
}
