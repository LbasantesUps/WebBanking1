using System;

namespace BankingLibrary
{
    public static class Operaciones
    {
        public static string Cuenta { get; set; }
        public static double? Saldo { get; set; }
        public static bool Abierta { get; set; }
        public static int? Movimientos { get; set; }

        public static void AperturaCuenta()
        {
            Cuenta = "1001";
            Saldo = 0;
            Abierta = true;
            Movimientos = 0;
        }

        public static void Deposito(double Valor)
        {
            Saldo += Valor;
            Movimientos++;
        }

        public static void Retiro(double Valor)
        {
            if (Saldo < Valor)
            {
                throw new ArgumentException("El valor de retiro sobregiro la cuenta");
            }
            else
            {
                Saldo -= Valor;
                Movimientos++;
            }
        }
    }
}
