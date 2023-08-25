namespace exercicio_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Digite o prmeiro número:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 < numero2)
            {
                for (numero1 = 0; numero1 <= numero2; numero1++)
                {

                        if (numero1 > 0 && numero1 % 3 == 0 && numero1 % 5 == 0)
                        {
                            Console.WriteLine($"\n{numero1} é multiplo de 3 e 5.");
                        }
                }
            }
            else
            {
                Console.WriteLine("\nintervalo inválido!");
            }

            }
        }
    }
