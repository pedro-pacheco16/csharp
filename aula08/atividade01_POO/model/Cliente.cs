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
        private string cpf = string.Empty;
        private int telefone;
        private string endereco = string.Empty;

        public Cliente(int id, string nome, string cpf, int telefone, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
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

        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
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

        public void visualizar()
        {
            Console.WriteLine("\n\n*********************************************************************");
            Console.WriteLine("Dados do Cliente:");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Numero do id: " + this.id);
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("cpf: " + cpf);
            Console.WriteLine("Telefone: " + this.telefone);
            Console.WriteLine("endereco: " + this.endereco);

        }
    }
        
}
