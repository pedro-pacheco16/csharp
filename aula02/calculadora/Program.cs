namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, divisao;

            Console.WriteLine("digite o primeiro numero:");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite o segundo numero:");
            numero2 = Convert.ToSingle(Console.ReadLine());//conversor de string para float
            divisao = numero1 / numero2;
            Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2));//numeros dentro das chaves guarda o valor digitado
            Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2)); 
             
            if(numero2 > 0)
            {
                Console.WriteLine($"{numero1} / {numero2} =  {divisao:F2}");
            }
            else
            {
                Console.WriteLine("Não existe divisão por zero!!");
            }

            Console.WriteLine($"{numero1} ^ {numero2} = " + Math.Pow(numero1, numero2));
            Console.WriteLine($"raiz quadrada de {numero1} = " + Math.Sqrt(numero2));
        }
    }
}