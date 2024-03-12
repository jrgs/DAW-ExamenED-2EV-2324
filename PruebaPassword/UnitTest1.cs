using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;


namespace PruebaPassword
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PasswordNoValida()
        {
            string password = "";
            comprobadorDePassword miPrueba = new comprobadorDePassword();
            Assert.AreEqual(-1, miPrueba.test(password));
        }

        [TestMethod]
        public void PasswordNoValida1()
        {
            string password = "abc";
            comprobadorDePassword miPrueba = new comprobadorDePassword();
            Assert.AreEqual(0, miPrueba.test(password));
        }

        [TestMethod]
        public void PasswordValida()
        {
            string password = "C0ntr@s3ñ@S3gur@";
            int fortaleza = 4;
            comprobadorDePassword miPrueba = new comprobadorDePassword();
            Assert.AreEqual(fortaleza, miPrueba.test(password));
        }
    }


}
