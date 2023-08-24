namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoProduto, Quantidade, valorTotal = 0;

            Console.WriteLine("1 - Cachorro Quente | R$10.00");
            Console.WriteLine("2 - X-Salada        | R$10.00");
            Console.WriteLine("3 - X-Bacon         | R$18.00");
            Console.WriteLine("4 - Bauru           | R$12.00");
            Console.WriteLine("5 - Refrigerante    | R$8.00");
            Console.WriteLine("6 - Suco de Laranja | R$13.00");
            Console.Write("Digite o código do Produto:");
            
            codigoProduto = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de produtos: ");
            Quantidade = Convert.ToInt32(Console.ReadLine());

            switch (codigoProduto)
            {
                case 1:
                    valorTotal = Quantidade * 10;
                    break;
                case 2:
                    valorTotal = Quantidade * 10;
                    break;
                case 3:
                    valorTotal = Quantidade * 18;
                    break;
                case 4:
                    valorTotal = Quantidade * 12;
                    break;
                case 5:
                    valorTotal = Quantidade * 8;
                    break;
                case 6:
                    valorTotal = Quantidade * 13;
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida");
                    break;
            }

            Console.WriteLine($"O valor total é R$: {valorTotal}");
        }
    }
}