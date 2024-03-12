using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;

namespace ComprobadorDePasswordTest
{
    [TestClass]
    public class ComprobadorDePasswordTest
    {
        [TestMethod]
        [DataRow("")]
        public void ValidarContraseñaVacia(string password)
        {
            try
            {
                RMB2324ComprobadorDePassword contraseña = new RMB2324ComprobadorDePassword();
                contraseña.Password = password;
            }
            catch (ArgumentOutOfRangeException error)
            {
                Assert.AreEqual(error.Message, RMB2324ComprobadorDePassword.ERR_CONTRASEÑA_NULA_O_VACIA);
                return;
            }
            Assert.Fail("Error. Se debería haber lanzado una excepción.");
        }
    }
}
