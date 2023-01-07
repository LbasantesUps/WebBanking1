using BankingLibrary;
using Xunit;

namespace TestProject
{
    public class UnitTestInteres
    {
        [Fact]
        public void TestInteres1()
        {
            decimal Monto = 100;
            decimal Tasa = 0.2M;
            double Resultado = Interes.CalculoInteres(Monto, Tasa);
            Assert.Equal(0.0546, Resultado, 4);
        }

        [Fact]
        public void TestInteres2()
        {
            // Cuando es 0
            decimal Monto = 0;
            decimal Tasa = 0.2M;
            double Resultado = Interes.CalculoInteres(Monto, Tasa);
            Assert.Equal(0, Resultado, 4);
        }

        [Fact]
        public void TestInteres3()
        {
            // Cuando el valor es negativo
            decimal Monto = -100;
            decimal Tasa = 0.2M;
            double Resultado = Interes.CalculoInteres(Monto, Tasa);
            Assert.Equal(0, Resultado, 4);
        }
    }
}
