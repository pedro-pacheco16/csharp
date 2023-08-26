namespace animaisex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? palavra1, palavra2, palavra3;

            Console.WriteLine("Digite a primeira palavra:");
            palavra1 = Console.ReadLine();

            Console.WriteLine("Digite a segunda palavra:");
            palavra2 = Console.ReadLine();

            Console.WriteLine("Digite a terceira palavra:");
            palavra3 = Console.ReadLine();

            if (palavra1 is not null && palavra2 is not null && palavra3 is not null)
            {
                //verificando se é vertebrado ou invertebrado
                if (palavra1.Equals("vertebrado"))
                {
                    // verificando se é ave ou mamifero
                    if (palavra2.Equals("ave"))
                    {
                        if (palavra3.Equals("carnivoro"))
                        {
                            Console.WriteLine("aguia");
                        }
                        else
                        {
                            Console.WriteLine("pomba");
                        }
                    }
                    else
                    {
                        if (palavra3.Equals("onivoro"))
                        {
                            Console.WriteLine("Homem");
                        }
                        else
                        {
                            Console.WriteLine("vaca");

                        }
                    }
                    if (palavra1.Equals("invertebrado"))
                    {

                        if (palavra2.Equals("inseto"))
                        {
                            if (palavra3.Equals("Hematófogo"))
                            {
                                Console.WriteLine("Pulga");
                            }
                            else
                            {
                                Console.WriteLine("Lagarta");
                            }
                        }
                        else
                        {
                            if (palavra3.Equals("anelídeo"))
                            {
                                Console.WriteLine("Sanguessuga");
                            }
                            else
                            {
                                Console.WriteLine("minhoca");

                            }
                        }

                    }

                }

            }
            else
            {
                Console.WriteLine("As palavras mão são nulas");
            }
        }
    }
}