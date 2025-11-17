using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAJEROLITEPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario(1, "Leo", 1234, 300000);
            Cajero cajero = new Cajero(usuario);
            cajero.Iniciar();
        }
    }
}
