namespace ex01_fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            String? nome;
            Queue<string> fila = new Queue<string>();

            do 
            { 

            Console.WriteLine("************************************************************************************\n");

            Console.WriteLine("1 - Adicionar Cliente na fila");
            Console.WriteLine("2 - Adicionar Todos os Clientes");
            Console.WriteLine("3 - Retirar Cliente da Fila");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("\n************************************************************************************");

            Console.WriteLine("\nEntre com a opção desejada:");
            codigo = Convert.ToInt32(Console.ReadLine());

            Console.Clear();



                if (codigo == 1)
                {
                    Console.WriteLine("Digite um nome:");
                    nome = Console.ReadLine();
                    fila.Enqueue(nome);

                    Console.WriteLine("\nFila:");

                    foreach (var nomes in fila)
                    {
                        Console.WriteLine(nomes);
                    }
                    Console.WriteLine("\nCliente Adicionado!\n");

                    Console.WriteLine("\n");

                }
                else if (codigo == 2)
                {
                    Console.WriteLine("\nLista de clientes na fila:");

                    foreach (var nomes in fila)
                    {
                        Console.WriteLine(nomes);
                        
                    }
                    Console.WriteLine("\n");
                }
                else if (codigo == 3)
                {
                    

                    if (fila.Count != 0) // count retorna o tmanho da fila.
                    {
                        fila.Dequeue();
                        Console.WriteLine("Fila:");
                        foreach (var nomes in fila)
                        {   

                            Console.WriteLine(nomes);
                        }

                        Console.WriteLine("O cliente foi chamado!");
                    }
                    else
                    {
                        Console.WriteLine("A fila está vazia!\n");
                    }
                }

            } while (codigo != 0);

            Console.WriteLine("Programa finalizado!");

        }
    }
}