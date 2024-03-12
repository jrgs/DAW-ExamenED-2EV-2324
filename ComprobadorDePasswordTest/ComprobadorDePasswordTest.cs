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

            ComprobadorDePasswordCDJ2324 miPassword = new ComprobadorDePasswordCDJ2324();
            try
            {
                miPassword.ComprobadorDePasswordTest("");
            }
            catch (ArgumentNullException e) {
                StringAssert.Contains(e.Message, ComprobadorDePasswordCDJ2324.PASS_NULA);
                return;
            }


            Assert.Fail("no se obtubo el error esperado");
            

        }

        [TestMethod]
        public void ErrorPasswordMuyCorta() 
        {  
            ComprobadorDePasswordCDJ2324 miPassword = new ComprobadorDePasswordCDJ2324();
            try
            {
                miPassword.ComprobadorDePasswordTest("abc");
            }
            catch (ArgumentOutOfRangeException e) {
                StringAssert.Contains(e.Message, ComprobadorDePasswordCDJ2324.PASSWORD_CORTA);
                return;
            }
            Assert.Fail("no se obtubo el error esperado");
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
