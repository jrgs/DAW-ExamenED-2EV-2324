using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;


namespace PruebaPassword
{
    [TestClass]
    public class PruebaPasswordTest
    {
        [TestMethod]
        public void PasswordNoValida()
        {
            string password = "";
            ComprobadorDePassword.ComprobadorDePassword miPrueba = new ComprobadorDePassword.ComprobadorDePassword();
            Assert.AreEqual(-1, miPrueba.Test(password));
        }

        [TestMethod]
        public void PasswordNoValida1()
        {
            string password = "abc";
            ComprobadorDePassword.ComprobadorDePassword miPrueba = new ComprobadorDePassword.ComprobadorDePassword();
            Assert.AreEqual(0, miPrueba.Test(password));
        }

        [TestMethod]
        public void PasswordValida()
        {
            string password = "C0ntr@s3ñ@S3gur@";
            int fortaleza = 4;
            ComprobadorDePassword.ComprobadorDePassword miPrueba = new ComprobadorDePassword.ComprobadorDePassword();
            Assert.AreEqual(fortaleza, miPrueba.Test(password));
        }
    }


}
