namespace ex02_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            String? livro;
            Stack<string> livraria = new Stack<string>();

            do
            {

                Console.WriteLine("************************************************************************************\n");

                Console.WriteLine("1 - Adicionar Livro na Pilha");
                Console.WriteLine("2 - Listar todos os Livros");
                Console.WriteLine("3 - Retirar Livro da Pilha");
                Console.WriteLine("0 - Sair");

                Console.WriteLine("\n************************************************************************************");

                Console.WriteLine("\nEntre com a opção desejada:");
                codigo = Convert.ToInt32(Console.ReadLine());

                Console.Clear();



                if (codigo == 1)
                {
                    Console.WriteLine("Digite um Livro:");
                    livro = Console.ReadLine();
                    livraria.Push(livro);

                    Console.WriteLine("\nPilha:");

                    foreach (var nomes in livraria)
                    {
                        Console.WriteLine(nomes);
                    }
                    Console.WriteLine("\nLivro Adicionado!\n");

                    Console.WriteLine("\n");

                }
                else if (codigo == 2)
                {
                    Console.WriteLine("\nLista de Livros na Pilha:");

                    foreach (var nomes in livraria)
                    {
                        Console.WriteLine(nomes);

                    }
                    Console.WriteLine("\n");
                }
                else if (codigo == 3)
                {


                    if (livraria.Count != 0) // count retorna o tmanho da livraria.
                    {
                        livraria.Pop();
                        Console.WriteLine("livraria:");
                        foreach (var nomes in livraria)
                        {

                            Console.WriteLine(nomes);
                        }

                        Console.WriteLine("Um Livro foi retirado!");
                    }
                    else
                    {
                        Console.WriteLine("A livraria está vazia!\n");
                    }
                }else if(codigo < 0 || codigo > 3)
                {
                    Console.WriteLine("Digite uma opção válida!\n");
                }

            } while (codigo != 0);

            Console.WriteLine("Programa finalizado!");
        }
    }
}