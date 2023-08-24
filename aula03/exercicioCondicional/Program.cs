namespace exercicioCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, soma;

            Console.WriteLine("Digite o numero de A:");
            a = Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine("Digite o numero de B:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o numero de C:");
            c = Convert.ToInt32(Console.ReadLine());

            soma = a + b;

            if(soma > c)
            {
                Console.WriteLine("A Soma de A + B é Maior do que C");
            }else if(soma < c)
            {
                Console.WriteLine("A Soma de A + B é Menor do que C");
            }else 
            {
                Console.WriteLine("A Soma de A + B é Igual a C");
            }

        }  
    }
}