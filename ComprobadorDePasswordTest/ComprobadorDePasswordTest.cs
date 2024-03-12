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
                contraseña.Test(password);
            }
            catch (ArgumentOutOfRangeException error)
            {
                StringAssert(error.Message, RMB2324ComprobadorDePassword.ERR_CONTRASEÑA_NULA_O_VACIA);
                return;
            }
            Assert.Fail("Error. Se debería haber lanzado una excepción.");
        }
    }

    [TestMethod]
    [DataRow("C0ntr@s3ñ@S3gur@", 4)]
    public void ValidarContrasenyaSegura(string pass, int fortaleza)
    {
        RMB2324ComprobadorDePassword contraseña = new RMB2324ComprobadorDePassword();
        contraseña.Password = pass;
        contraseña.Test(pass);

        Assert.AreEqual(fortaleza, contraseña.Test(pass));
    }
}
