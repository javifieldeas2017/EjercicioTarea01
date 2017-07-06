using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioTarea01;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClaseDatos sut = new ClaseDatos();
            ClaseLogica herramienta = new ClaseLogica();
            sut.texto = "x";
            sut.a = 5;
            sut.b = 6;

            String resultado = herramienta.ConcatenarAtributos(sut);
            String comparacion = "x-5-6";

            Assert.AreEqual(resultado, comparacion);
        }
    }
}
