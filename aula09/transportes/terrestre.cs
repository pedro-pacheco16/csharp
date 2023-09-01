using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportes
{
    public class terrestre : transporte
    {
        private int rodas;
        private int velocidade;

        public terrestre(int capacidade, int rodas, int velocidade) : base(capacidade)
        {
            this.rodas = rodas;
            this.velocidade = velocidade;
        }

        public int GetRodas()
        {
            return rodas;
        
        }
        public void SetRodas(int rodas)
        {
            this.rodas = rodas;
        }

        public int Getvelocidade()
        {
            return velocidade;
        }

        public void Setvelocidade(int velocidade)
        {
            this.velocidade = velocidade;
        }

        //sobrescrevendo o metódo da classe mãe usando o (override)
        public override void Visualizar()
        {
            base.Visualizar();

            Console.WriteLine($"Número de rodas: {rodas}");
            Console.WriteLine($"Velocidade: {velocidade}");
        }
    }
}
