namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nomeDoDoador;
            int idade;
            bool PrimeiraDocao;

            Console.WriteLine("Digite o nome do doador(a):");
            nomeDoDoador = (Console.ReadLine());

            Console.WriteLine($"{nomeDoDoador}, digite a sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine($"Seria a sua primeira Doação de sangue {nomeDoDoador}? Digite true = Sim e false = Não ");
             PrimeiraDocao = Convert.ToBoolean(Console.ReadLine());
            
            if (idade >= 18 && idade <= 59 )
            {
                Console.WriteLine($"{nomeDoDoador}, você está apto para doar sangue!");


            }
            
            else if (idade >= 60 && idade <= 69 && PrimeiraDocao != true )
            {
                Console.WriteLine($"{nomeDoDoador}, você está apto para doar sangue!");
            }
            else
            {
                Console.WriteLine($"{nomeDoDoador}, você não está apto para doar sangue!");
            }
            

        }
    }
}