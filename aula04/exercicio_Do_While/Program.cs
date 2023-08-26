namespace exercicio_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, somaPositivo = 0;

            do
            {
                Console.WriteLine("Digite um número:");
                numero = Convert.ToInt32(Console.ReadLine());

            if(numero > 0)
            {
                somaPositivo += numero;

            }
            } while (numero != 0);

            Console.WriteLine($"soma dos números positivos: {somaPositivo}");

        }
    }
}