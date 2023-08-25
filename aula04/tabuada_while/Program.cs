namespace tabuada_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero,resultado, cont = 3;
            do
            {

                Console.WriteLine("Digite um numero inteiro:");
                numero = Convert.ToInt32(Console.ReadLine());
                resultado = numero * 5;
                Console.WriteLine("\nO resultado da multiplicação é:");
            } while (cont <= 10);
            
           
                
            
        }
    }
}