namespace ex2_laco_repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0 && num > 0)
            {
                Console.Write($"\nO número {num} é par e positivo! ");
           
            } else if (num % 2 == 0 && num < 0)
            {
                Console.Write($"\nO número {num} é par e negativo! ");
            }
            else if (num % 2 != 0 && num > 0)
            {
                Console.Write($"\nO número {num} é impar e positivo! ");

            }
            else
            {
                Console.Write($"\nO número {num} é impar e negativo! ");
            }
        }
    }
}