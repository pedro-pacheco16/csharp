namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBruto,AdicionalNoturno , HorasExtras,Descontos, SalarioLiquido;
            Console.WriteLine("digite o salario Bruto:");
            salarioBruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite o Adicional Noturno:");
            AdicionalNoturno = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite as Horas Extras:");
            HorasExtras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("digite os Descontos:");
            Descontos = Convert.ToSingle(Console.ReadLine());

            SalarioLiquido = salarioBruto + AdicionalNoturno + (HorasExtras * 5) - Descontos;


            Console.WriteLine("Salario Liquido = " + Math.Round(SalarioLiquido, 2));
        }
    }
}