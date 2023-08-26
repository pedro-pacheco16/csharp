using System.Diagnostics;

namespace exercicio_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, identidadeDeGenero = 0, pessoaDesenvolvedora = 0;
            int backend = 0, mulheresFront = 0,homemM40 = 0, naoBim30 = 0, total =0;
            float media = 0, somaDasIdades = 0;
            string? continua = "S";

            while (continua == "S")
            {



                Console.Write("Digite sua idade:");
                idade = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("\n1 – Mulher Cis");
                    Console.WriteLine("2 - Homem Cis");
                    Console.WriteLine("3 – Não Binário");
                    Console.WriteLine("4 – Mulher Trans");
                    Console.WriteLine("5 – Homem Trans");
                    Console.WriteLine("6 – Outros");


                    Console.WriteLine("Digite sua identidade de Gênero:");
                    identidadeDeGenero = Convert.ToInt32(Console.ReadLine());


                }while (identidadeDeGenero < 1 || identidadeDeGenero > 6);

                do
                {
                    Console.WriteLine("1 – Backend");
                    Console.WriteLine("2 - Frontend");
                    Console.WriteLine("3 – Mobile");
                    Console.WriteLine("4 – Fullstack");

                    Console.WriteLine("Digite sua área de atuação:");
                    pessoaDesenvolvedora = Convert.ToInt32(Console.ReadLine());

                } while (pessoaDesenvolvedora < 1 || pessoaDesenvolvedora > 4);
               

                if(pessoaDesenvolvedora == 1)
                {
                    backend++;
                }
                if((identidadeDeGenero == 1 || identidadeDeGenero == 4) && pessoaDesenvolvedora == 2)
                {
                    mulheresFront++;
                }
                if ((identidadeDeGenero == 2 || identidadeDeGenero == 5) && pessoaDesenvolvedora == 3 && idade > 40)
                {
                    homemM40++;
                }
                if(identidadeDeGenero == 3 && pessoaDesenvolvedora == 4 && idade < 30)
                {
                    naoBim30++;
                }
                Console.WriteLine("Digite continuar? [S]/[N] ");
                continua = Console.ReadLine().ToUpper();


                total++;

                somaDasIdades = somaDasIdades + idade;
                media = somaDasIdades / total;
            }
                Console.WriteLine($"o número de pessoas desenvolvedoras Backend:{backend}");
                Console.WriteLine($"O número de Mulheres Cis e Trans desenvolvedoras Frontend: {mulheresFront}");
                Console.WriteLine($"O número de Homens Cis e Trans desenvolvedores Mobile maiores de 40 anos: {homemM40}");
                Console.WriteLine($"O número de Não Binários desenvolvedores FullStack menores de 30 anos:{naoBim30}");
                Console.WriteLine($"O número total de pessoas que responderam à pesquisa:{total}");
                Console.WriteLine($"A média de idade das pessoas que responderam à pesquisa: {media:F2}");







        }
    }
}