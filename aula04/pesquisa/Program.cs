namespace pesquisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome, continua = "S";
            int idade, esporte, futebol = 0, voleibolmai18 = 0, basquetemen18 = 0;

            do
            {
                Console.WriteLine("Digite o seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite o seu esporte favorito (1-Futebol/2-vôlei/3-basquete/4-outros");
                    esporte = Convert.ToInt32(Console.ReadLine());

                } while (esporte < 1 || esporte > 4);

                Console.WriteLine("Digite continuar? [S]/[N] ");
                continua = Console.ReadLine().ToUpper();

                if (esporte == 1)
                {
                    futebol++;
                }
                if (esporte == 2 && idade > 18)
                {
                    voleibolmai18++;
                }
                if (esporte == 3 && idade < 18)
                {
                    basquetemen18++;
                }


            } while (continua.Equals("S"));

            Console.WriteLine($"total de pessoas que gostam de futebol: {futebol}");
            Console.WriteLine($"total de pessoas que gostam de voleibol maiores de 18: {voleibolmai18}");
            Console.WriteLine($"total de pessoas que gostam de basquetebol menores que 18: {basquetemen18}");

        }
    }
}