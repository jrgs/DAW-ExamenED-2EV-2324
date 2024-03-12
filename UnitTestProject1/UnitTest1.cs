using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(-1)]
        public void PasswordNula(int password)
        {
            // preparacion
            ComprobadorDePasswordATMS2324 prueba = new ComprobadorDePasswordATMS2324 ();

            // funcion
            int resultado = prueba.test("");

            // Assert
            Assert.AreEqual(resultado, password);
        }
    }
}
