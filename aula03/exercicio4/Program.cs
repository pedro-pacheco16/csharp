namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            float salario, novoSalario = 0;
            int cargo;

            Console.Write("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("\n1 - Gerente");
            Console.WriteLine("2 - Vendendor");
            Console.WriteLine("3 - Supervisor");
            Console.WriteLine("4 - Motorista");
            Console.WriteLine("5 - Estoquista");
            Console.WriteLine("6 - Técnico em TI");

            Console.Write("\nDigite o seu cargo:");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite o seu salario:");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    novoSalario = salario + (10 * salario) / 100;
                    break;
                case 2:
                    novoSalario = salario + (7 * salario) / 100;
                    break;
                case 3:
                    novoSalario = salario + (9 * salario) / 100;
                    break;
                case 4:
                    novoSalario = salario + (6 * salario) / 100;
                    break;
                case 5:
                    novoSalario =salario +  (5 * salario) / 100;
                    break;
                case 6:
                    novoSalario = salario + (8 * salario) / 100;
                    break;
                default:
                    Console.Write("Digite uma opção válida!");
                    break;

            }

            Console.WriteLine($"\nO novo salário do(a) {nome} é de: {novoSalario}");
         
        }
    }
}