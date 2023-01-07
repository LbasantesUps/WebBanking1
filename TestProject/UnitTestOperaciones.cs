﻿using BankingLibrary;
using System;
using Xunit;

namespace TestProject
{
    public class UnitTestOperaciones
    {
        [Fact]
        public void TestAperturaCuentas()
        {
            // Entradas
            bool CuentaValida = false;

            // Proceso
            Operaciones.AperturaCuenta();
            CuentaValida = Operaciones.Abierta;

            // Salida
            Assert.True(CuentaValida);
        }

        [Fact]
        public void TestDeposito()
        {
            // Entrada
            Operaciones.AperturaCuenta();

            // Proceso
            Operaciones.Deposito(100);

            // Salida
            Assert.Equal(100, Operaciones.Saldo);
        }

        [Fact]
        public void TestRetiro()
        {
            // Entrada
            Operaciones.AperturaCuenta();

            // Proceso
            Operaciones.Deposito(100);
            Operaciones.Retiro(20);

            // Salida
            Assert.Equal(80, Operaciones.Saldo);
        }

        [Fact]
        public void TestRetiroSobreGiroNoPermitido()
        {
            // Entrada
            bool SobreGiro = false;

            // Proceso
            try
            {                
                Operaciones.AperturaCuenta();
                Operaciones.Deposito(20);
                Operaciones.Retiro(100);
                if (Operaciones.Saldo < 0)
                {
                    SobreGiro = true;
                }

                // Salida
                Assert.False(SobreGiro);
            }
            catch
            {
                // Salida
                Assert.True(true);
            }
        }

        [Fact]
        public void TestRetiroExceptionSobreGiro()
        {
            // Entrada
            Operaciones.AperturaCuenta();

            // Proceso
            Operaciones.Deposito(20);

            // Salida
            Assert.Throws<ArgumentException>(() => Operaciones.Retiro(100));
        }

        [Fact]
        public void TestSaldo()
        {
            // Entrada
            Operaciones.AperturaCuenta();

            // Proceso
            Operaciones.Deposito(100);
            Operaciones.Retiro(100);

            // Salida
            Assert.Equal(0, Operaciones.Saldo);
        }
    }
}