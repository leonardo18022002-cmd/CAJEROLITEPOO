using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAJEROLITEPOO
{
    internal class Cuenta
    {
        public double Saldo { get; private set; }

        public Cuenta(double saldoInicial)
        {
            Saldo = saldoInicial >= 0 ? saldoInicial : 0;
        }

        public void Depositar(double monto)
        {
            if (monto <= 0)
                Console.WriteLine("❌ El monto debe ser positivo.");
            else
            {
                Saldo += monto;
                Console.WriteLine($"✅ Depósito exitoso. Nuevo saldo: ${Saldo}");
            }
        }

        public void Retirar(double monto)
        {
            if (monto <= 0)
                Console.WriteLine("❌ El monto debe ser positivo.");
            else if (monto > Saldo)
                Console.WriteLine("❌ Fondos insuficientes.");
            else
            {
                Saldo -= monto;
                Console.WriteLine($" Retiro exitoso. Nuevo saldo: ${Saldo}");
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($" Saldo disponible: ${Saldo}");
        }
    }
}
