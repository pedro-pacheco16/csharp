namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, novoSalario;
            Console.WriteLine("digite o salário:");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite o abono:");
            abono = Convert.ToSingle(Console.ReadLine());

            novoSalario = salario + abono;

           Console.WriteLine("novo salário = " + Math.Round(novoSalario,2));
        }
    }
}