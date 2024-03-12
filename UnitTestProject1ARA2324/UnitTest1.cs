using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1ARA2324
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_ContrasenyaVacia() //Debe devolver -1
        {
            ComprobadorDePassword comprobador = new ComprobadorDePassword();
            int resultado = comprobador.Probar("");
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void Test_ContrasenyaDebil() //Debe devolver 0
        {
            ComprobadorDePassword comprobador = new ComprobadorDePassword();
            int resultado = comprobador.Probar("abc");
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Test_ContrasenyaFuerte() //Debe devolver 4
        {
            ComprobadorDePassword comprobador = new ComprobadorDePassword();
            int resultado = comprobador.Probar("C0ntr@s3ñ@S3gur@");
            Assert.AreEqual(4, resultado);
        }

    }
}
