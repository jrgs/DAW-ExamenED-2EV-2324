using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;

namespace ComprobadorDePasswordTestCBT2324
{
    [TestClass]
    public class ComprobadorDePasswordTestCBT2324
    {
        [TestMethod]
        public void ProbarContraseñaNula()
        {
            string p = "";

            comprobadorDePassword miPrueba = new comprobadorDePassword ();

            int resultado = miPrueba.ProbarContraseña(p);

            Assert.AreEqual(resultado, -1, "contraseña nula o vacia");
        }

        [TestMethod]
        public void ProbarContraseñaMenorDeSeis()
        {
            string p = "abc";

            comprobadorDePassword miPrueba = new comprobadorDePassword();

            int resultado = miPrueba.ProbarContraseña(p);

            Assert.AreEqual(resultado, 0, "contraseña menor de 6 caracteres");
        }

        [TestMethod]
        public void ProbarContraseñaMayorDeDoce()
        {
            string p = "C0ntr@s3ñ@S3gur@\"";

            comprobadorDePassword miPrueba = new comprobadorDePassword();

            int resultado = miPrueba.ProbarContraseña(p);

            Assert.AreNotEqual(resultado,0, "contraseña nula o vacia");
        }
    }
}
