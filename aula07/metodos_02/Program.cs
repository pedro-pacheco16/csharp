using metodos_02.nameSpace01;

namespace metodos_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodoPublico();
            MetodoInternal();
            MetodoProtegido();
            MetodoPrivado();

            Class1.MetodoPublico();
            Class1.MetodoInternal();


            Class2.MetodoPublico();
            Class2.MetodoInternal();

        }

        public static void MetodoPublico()
        {
            Console.WriteLine("Método Púbico - Classe Program");
        }
        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe Program");
        }
        protected static void MetodoProtegido()
        {
            Console.WriteLine("Método Púbico - Classe Program");
        }
        private static void MetodoPrivado()
        {
            Console.WriteLine("Método Privado- Classe Program");
        }
    }
}