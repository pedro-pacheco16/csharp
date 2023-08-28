namespace exercicio03_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0 , numM50 = 0, Numm21 = 0;



            while (idade >= 0)
            {
                Console.Write("Digite sua idade:");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade >=  0)
                {
                    if (idade < 21)
                    {
                        Numm21++;

                    }

                    else if (idade > 50)
                    {
                        numM50++;

                    }

                }

            }
                 Console.Write($"\nTotal de pessoas menores de 21 anos: {Numm21}");
                 Console.Write($"\nTotal de pessoas maiores de 50 anos: {numM50}");

           }

        }
    }

