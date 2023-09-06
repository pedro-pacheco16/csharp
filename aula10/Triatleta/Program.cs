namespace Triatleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triatleta t1 = new Triatleta("Pedro");

            t1.Aquecer();
            t1.Correr();
            t1.Nadar();
            t1.pedalar();
            t1.Cansou();
        }
    }
}