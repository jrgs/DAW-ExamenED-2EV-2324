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
    }
}
