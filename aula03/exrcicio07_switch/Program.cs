namespace exrcicio07_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2,resultado = 0;
            int codigo;

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.Write("\nDigite um código :");
            codigo = Convert.ToInt32(Console.ReadLine());


            if (codigo <= 0 || codigo > 4)
            {
                Console.Write("\nOpção Inválida!");

            }else
            {
            Console.Write("\nDigite o primeiro número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite o segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

                  switch (codigo)
                  {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"\nResultado = {resultado}");
                        break;

                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"\nResultado = {resultado}");
                        break;

                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"\nResultado = {resultado}");
                        break;

                    case 4:
                        if(num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"\nResultado = {resultado}");
                           
                        }
                        else
                        {
                            Console.WriteLine("\nNão é possivel dividir por zero!");
                        }
                        
                        break;
                  }
            }
        }
    }          
}