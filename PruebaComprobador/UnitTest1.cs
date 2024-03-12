using ComprobadorDePassword;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace PruebaComprobador
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ContrasenyaVacia()
        {
            string contrasenya = "";

            ComprobadorDePasswordAPG2324 miComprobador = new ComprobadorDePasswordAPG2324 ();

            miComprobador.Test(contrasenya);

            try
            {
                
            }
            catch
            {

            }

        }

        [TestMethod]
        public void ContrasenyaSegura()
        {
            string contrasenya = "C0ntr@s3ñ@S3gur@";
            int esperado = 4;

            ComprobadorDePasswordAPG2324 miComprobador = new ComprobadorDePasswordAPG2324();

            miComprobador.Test(contrasenya);

            Assert.AreEqual(miComprobador.Test, esperado);

        }

        [TestMethod]
        public void ContrasenyaCorta()
        {
            string contrasenya = "abc";

            ComprobadorDePasswordAPG2324 miComprobador = new ComprobadorDePasswordAPG2324();

            miComprobador.Test(contrasenya);

            try
            {

            }
            catch
            {

            }
        }
           
    }
}
