using metodos_02.nameSpace01;

namespace metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, divisao;

            Console.WriteLine("Digite o primeiro número:");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{numero1} + {numero2} = " + somar(numero1,numero2));
            Console.WriteLine($"{numero1} - {numero2} = " + subtrair(numero1, numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + multiplicar(numero1, numero2));

            divisao = dividir(numero1, numero2);            
            Console.WriteLine(divisao == 0 ?"Não existe Divisão por zero" : $"{numero1}/ {numero2} = { divisao}");
            Console.WriteLine($"{numero1} ^ {numero2} = " + potencia(numero1, numero2));
            Console.WriteLine($"Raiz quadrada de {numero1} = " + raiz(numero1));
            Dev();

            Class2.MetodoPublico();
        }
        static float somar(float numero1,float numero2)
        {
            return numero1 + numero2;
        }
        static float subtrair(float numero1, float numero2)
        {
            return numero1 - numero2;
        }
        static float multiplicar(float numero1, float numero2)
        {
            return numero1 * numero2;
        }
        static float dividir(float numero1, float numero2)
        {
            if (numero2 > 0)
                return numero1 / numero2;
            else
                return 0;
        }
        static double potencia(float numero1, float numero2)
        {
            return Math.Pow(numero1,numero2);
        }
        static double raiz(float numero1)
        {
            return Math.Sqrt(numero1);
        }
        static void Dev()
        {
            Console.WriteLine("Criado por: Pedro");
        }
    }
}