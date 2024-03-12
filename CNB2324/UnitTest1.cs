using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;

namespace CNB2324
{
    public class PruebaPassword2324
    {
        [TestMethod]
        public void ValidarContrasenya1()
        {
            try
            {

                string PasswordIntroducido = "";
                ComprobadorDePasswordCNB2324 contrasenya = new ComprobadorDePasswordCNB2324();

                int ResultadoEsperado = contrasenya.Test(PasswordIntroducido);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                // assert
                StringAssert.Contains(exception.Message,
               ComprobadorDePasswordCNB2324.ERROR_CONTRASENYA_NULA);
                return;
            }
            Assert.Fail("Error. Se debía haber producido una excepción.");
        }


        public void ValidarContrasenya2()
        {
            try
            {
                string PasswordIntroducido = "abc";
                ComprobadorDePasswordCNB2324 contrasenya = new ComprobadorDePasswordCNB2324();

                int ResultadoEsperado = contrasenya.Test(PasswordIntroducido);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                StringAssert.Contains(exception.Message,
               ComprobadorDePasswordCNB2324.ERROR_CONTRASENYA_INVALIDA);
                return;
            }
            Assert.Fail("Error. Se debía haber producido una excepción.");
        }

       

        [TestMethod]
        public void ValidarContrasenya3()
        {
            int PasswordEsperado = 4;
            string PasswordIntroducido = "C0ntr@s3ñ@S3gur@";

            ComprobadorDePasswordCNB2324 contrasenya = new ComprobadorDePasswordCNB2324();

            int ResultadoEsperado = contrasenya.Test(PasswordIntroducido);

            Assert.AreEqual(PasswordEsperado, ResultadoEsperado);
        }



       
    }

}

