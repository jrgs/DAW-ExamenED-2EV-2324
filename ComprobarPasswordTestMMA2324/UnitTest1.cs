using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;

namespace ComprobarPasswordTestMMA2324
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("", -1)]
        public void PasswordNulo(string password, int resultadoEsperado)
        {
            ComprobadorDePasswordMMA2324 comprobar = new ComprobadorDePasswordMMA2324();

            Assert.AreEqual(resultadoEsperado, comprobar.Test(password), "Error");
        }

        [TestMethod]
        [DataRow("abc", 0)]
        public void PasswordMenorQue6(string password, int resultadoEsperado)
        {
            ComprobadorDePasswordMMA2324 comprobar = new ComprobadorDePasswordMMA2324();

            Assert.AreEqual(resultadoEsperado, comprobar.Test(password), "Error");
        }

        [TestMethod]
        [DataRow("C0ntr@s3ñ@S3gur@", 4)]
        public void PasswordMuySeguro(string password, int resultadoEsperado)
        {
            ComprobadorDePasswordMMA2324 comprobar = new ComprobadorDePasswordMMA2324();

            Assert.AreEqual(resultadoEsperado, comprobar.Test(password), "Error");
        }
    }
}
