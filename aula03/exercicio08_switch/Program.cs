namespace exercicio08_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float saldo = 1000, valor = 0, novoSaldo = 0;
            int codigoOperacao;

            Console.WriteLine("1 - Saldo");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Depósito");

            Console.Write("\nDigite um código :");
            codigoOperacao = Convert.ToInt32(Console.ReadLine());


            if (codigoOperacao <= 0 || codigoOperacao > 3)
            {
                Console.Write("\nOpção Inválida!");

            }
            else
            {

                switch (codigoOperacao)
                {
                    case 1:

                        Console.WriteLine($"\nSaldo = {saldo}");
                        break;

                    case 2:

                        Console.WriteLine($"\nDigite o valor a ser sacado:");
                        valor = Convert.ToSingle(Console.ReadLine());
                        if (valor > saldo)
                        {
                            Console.WriteLine($"\nSaldo insuficiente:");
                        }
                        else
                        {
                            novoSaldo = saldo - valor;
                            Console.WriteLine($"\nNovo Saldo: {novoSaldo}");
                        }
                        break;

                    case 3:

                        Console.WriteLine($"\nDigite o valor a ser Depositado:");
                        valor = Convert.ToSingle(Console.ReadLine());

                        if (valor > saldo)
                        {
                            Console.WriteLine("Operação Inválida!");
                        }
                        else
                        {
                            Console.WriteLine($"Novo Saldo: {novoSaldo + valor}");
                        }


                        break;
                }

            }
        }
    }
}
        
