using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_02
{
    public class Class1
    {
        public static void MetodoPublico()
        {
            Console.WriteLine("Método Púbico - Classe 01");
        }
        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe 01");
        }
        protected static void MetodoProtegido()
        {
            Console.WriteLine("Método Púbico - Classe 01");
        }
        private static void MetodoPrivado()
        {
            Console.WriteLine("Método Privado- Classe 01");
        }
    }
}
