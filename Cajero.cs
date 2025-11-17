using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAJEROLITEPOO
{
    internal class Cajero
    {
        private Usuario UsuarioActual;

        public Cajero(Usuario usuario)
        {
            UsuarioActual = usuario;
        }

        public void Iniciar()
        {
            Utilidades.MostrarEncabezado("Cajero Lite POO");

            Console.Write("Ingrese su ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su PIN: ");
            int pin = int.Parse(Console.ReadLine());

            if (UsuarioActual.ValidarAcceso(id, pin))
            {
                Console.WriteLine($"\n👋 Bienvenido, {UsuarioActual.Nombre}!");
                MostrarMenu();
            }
            else
            {
                Console.WriteLine("❌ Credenciales incorrectas.");
            }
        }

        private void MostrarMenu()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Retirar");
                Console.WriteLine("4. Cambiar PIN");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = Utilidades.LeerEntero();

                switch (opcion)
                {
                    case 1:
                        UsuarioActual.Cuenta.ConsultarSaldo();
                        break;
                    case 2:
                        Console.Write("Ingrese monto a depositar: ");
                        double montoDep = Utilidades.LeerDouble();
                        UsuarioActual.Cuenta.Depositar(montoDep);
                        break;
                    case 3:
                        Console.Write("Ingrese monto a retirar: ");
                        double montoRet = Utilidades.LeerDouble();
                        UsuarioActual.Cuenta.Retirar(montoRet);
                        break;
                    case 4:
                        Console.Write("Ingrese nuevo PIN (4 dígitos): ");
                        int nuevoPin = Utilidades.LeerEntero();
                        UsuarioActual.CambiarPin(nuevoPin);
                        break;
                    case 5:
                        Console.WriteLine("👋 Gracias por usar el Cajero Lite. ¡Hasta pronto!");
                        break;
                    default:
                        Console.WriteLine("⚠️ Opción no válida.");
                        break;
                }

            } while (opcion != 5);
        }
    }
}
