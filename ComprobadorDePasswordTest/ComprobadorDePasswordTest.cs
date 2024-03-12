using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;


namespace ComprobadorDePasswordTest
{
    [TestClass]
    public class ComprobadorDePasswordTest
    {
        [TestMethod]
        public void ErrorPasswordNula()
        {
            int codigoErrorEsperado = -1;
            int codigoObtenido;

            ComprobadorDePasswordCDJ2324 miPassword = new ComprobadorDePasswordCDJ2324();

            codigoObtenido = miPassword.ComprobadorDePasswordTest("");

            Assert.AreEqual(codigoErrorEsperado, codigoObtenido);
            

        }

        [TestMethod]
        public void ErrorPasswordMuyCorta() 
        {  
            int codigoErrorEsperado = 0;
            int codigoObtenido;

            ComprobadorDePasswordCDJ2324 miPassword = new ComprobadorDePasswordCDJ2324();

            codigoObtenido = miPassword.ComprobadorDePasswordTest("abc");

            Assert.AreEqual(codigoErrorEsperado, codigoObtenido);
        }

        [TestMethod]
        public void PasswordCorrecta()
        {
            int codigoEsperado = 4;
            int codigoObtenido;

            ComprobadorDePasswordCDJ2324 miPassword = new ComprobadorDePasswordCDJ2324();

            codigoObtenido = miPassword.ComprobadorDePasswordTest("C0ntr@s3ñ@S3gur@");

            Assert.AreEqual(codigoEsperado, codigoObtenido);
        }
    }
}
