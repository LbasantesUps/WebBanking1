namespace BankingLibrary
{
    public static class Interes
    {
        public static double CalculoInteres(decimal Monto, decimal Tasa)
        {
            // Entradas
            double Interes = 0;
            int Dias = 366;
            
            // Procesos
            if (Monto > 0)
            {
                Interes = (double)(Monto * Tasa / Dias);
            }

            // Salida
            return Interes;
        }
    }
}
