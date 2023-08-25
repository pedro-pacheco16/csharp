namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite a tabuada:");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int cont = 1; cont <= 10; cont++)
            {
                Console.WriteLine($"{numero} x {cont} = {numero * cont}");
            }
        }
    }
}