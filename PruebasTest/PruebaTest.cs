using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;

namespace PruebasTest
{
    [TestClass]
    public class PruebaTest
    {
        [TestMethod]
        public void ContrasenyaSinCaracteres()
        {
            ComprobadorDePasswordEEGS2324 sinCaracter = new ComprobadorDePasswordEEGS2324();

            string vacio = "";

            int respuesta = -1;

            Assert.AreEqual(sinCaracter.Test(vacio), respuesta);
        }

        [TestMethod]
        public void ContrasenyaCorta()
        {
            ComprobadorDePasswordEEGS2324 corta = new ComprobadorDePasswordEEGS2324();

            string tresLetras = "abc";

            int respuesta = 0;

            Assert.AreEqual(corta.Test(tresLetras), respuesta);
        }

        
        [TestMethod]
        public void ContrasenyaValida()
        {
            ComprobadorDePasswordEEGS2324 valida = new ComprobadorDePasswordEEGS2324();

            string optima = "C0ntr@s3ñ@S3gur@";

            int respuesta = 4;

            Assert.AreEqual(valida.Test(optima), respuesta);
        }

    }
}
