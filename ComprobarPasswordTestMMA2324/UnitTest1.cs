using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;

namespace ComprobarPasswordTestMMA2324
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("")]
        public void PasswordNulo(string password)
        {
            ComprobadorDePasswordMMA2324 comprobar = new ComprobadorDePasswordMMA2324();

            try
            {
                comprobar.TestValidacionPassword(password); 
            }
            catch (ArgumentOutOfRangeException Error)
            {
                StringAssert.Contains(Error.Message, comprobar.ERROR_PASSWORD_VACIO);
                return;
            }
            Assert.Fail("Se debería haber producido una excepción.");
        }

        [TestMethod]
        [DataRow("abc")]
        public void PasswordMenorQue6(string password)
        {
            ComprobadorDePasswordMMA2324 comprobar = new ComprobadorDePasswordMMA2324();

            try
            {
                comprobar.TestValidacionPassword(password);
            }
            catch (ArgumentOutOfRangeException Error)
            {
                StringAssert.Contains(Error.Message, comprobar.ERROR_PASSWORD_MENOR6);
                return;
            }
            Assert.Fail("Se debería haber producido una excepción.");

        }

        [TestMethod]
        [DataRow("C0ntr@s3ñ@S3gur@", 4)]
        public void PasswordMuySeguro(string password, int resultadoEsperado)
        {
            ComprobadorDePasswordMMA2324 comprobar = new ComprobadorDePasswordMMA2324();

            Assert.AreEqual(resultadoEsperado, comprobar.TestValidacionPassword(password), "Error");
        }
    }
}
