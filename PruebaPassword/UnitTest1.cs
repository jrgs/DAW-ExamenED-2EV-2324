using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;

namespace PruebaPassword
{
    [TestClass]
    public class UnitTest1
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

        
}
