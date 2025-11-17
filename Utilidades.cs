using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAJEROLITEPOO
{
    internal class Utilidades
    {
        public static void MostrarEncabezado(string titulo)
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine($"      {titulo.ToUpper()}");
            Console.WriteLine("================================\n");
        }

        public static int LeerEntero()
        {
            int valor;
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Intente nuevamente: ");
            }
            return valor;
        }

        public static double LeerDouble()
        {
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Entrada inválida. Intente nuevamente: "); //
            }
            return valor;
        }
    }
}
