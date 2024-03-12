using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;

namespace CNB2324
{
    public class PruebaPassword2324
    {
        [TestMethod]
        public void validarContrasenya1()
        {
            int PasswordEsperado = -1;
            string PasswordIntroducido = "";

            comprobadorDePasswordCNB2324 contrasenya = new comprobadorDePasswordCNB2324();

            int ResultadoEsperado = contrasenya.Test(PasswordIntroducido);

            Assert.AreEqual(PasswordEsperado, ResultadoEsperado);
        }

        [TestMethod]

        public void validarContrasenya2()
        {
            int PasswordEsperado = 0;
            string PasswordIntroducido = "abc";

            comprobadorDePasswordCNB2324 contrasenya = new comprobadorDePasswordCNB2324();

            int ResultadoEsperado = contrasenya.Test(PasswordIntroducido);

            Assert.AreEqual(PasswordEsperado, ResultadoEsperado);
        }

        public void validarContrasenya3()
        {
            int PasswordEsperado = 4;
            string PasswordIntroducido = "C0ntr@s3ñ@S3gur@";

            comprobadorDePasswordCNB2324 contrasenya = new comprobadorDePasswordCNB2324();

            int ResultadoEsperado = contrasenya.Test(PasswordIntroducido);

            Assert.AreEqual(PasswordEsperado, ResultadoEsperado);
        }

    }

}

