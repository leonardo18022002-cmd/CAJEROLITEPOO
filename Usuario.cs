using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAJEROLITEPOO
{
    internal class Usuario
    {
        public int IdUsuario { get; private set; }
        public string Nombre { get; private set; }
        private int Pin;


        public Cuenta Cuenta { get; private set; }

        public Usuario(int idUsuario, string nombre, int pin, double saldoInicial)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Pin = pin;
            Cuenta = new Cuenta(saldoInicial);
        }

        public bool ValidarAcceso(int id, int pin)
        {
            return IdUsuario == id && Pin == pin;
        }

        public void CambiarPin(int nuevoPin)
        {
            if (nuevoPin < 1000 || nuevoPin > 9999)
                Console.WriteLine("El PIN debe tener 4 dígitos.");
            else
            {
                Pin = nuevoPin;
                Console.WriteLine("El PIN actualizado correctamente.");
            }
        }
    }
}
