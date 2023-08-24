namespace RH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;// o "?" diz que a variavel nome é nulo
            float salario, reajuste;
            int cargo;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("1 - supervisor");
            Console.WriteLine("2 - Diretor");
            Console.WriteLine("3 - Gerente");
            Console.WriteLine("4 - outros");

            Console.WriteLine("Digite o seu cargo:");
            cargo = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o seu salario:");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 7) / 100;
                    break;
                case 2:
                    reajuste = (salario * 9) / 100;
                    break;
                case 3:
                    reajuste = (salario * 5) / 100;
                    break;
                default:
                    reajuste = (salario * 12);
                    break;
                    
             }

            Console.WriteLine($"O reajuste do salário do(a) {nome} é de: {reajuste}");
            Console.WriteLine($"O novo do(a) {nome} é de: {reajuste + salario}");



        }
    }
}