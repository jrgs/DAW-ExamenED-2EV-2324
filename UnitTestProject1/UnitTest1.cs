using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComprobadorDePassword;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // PRUEBA PARA UNA PASWORDD ""
        [TestMethod]
        [DataRow(-1)]
        public void PasswordNula(int password)
        {
            // preparacion
            string cadena = "";
            ComprobadorDePasswordATMS2324 prueba = new ComprobadorDePasswordATMS2324 ();

            // funcion a probar
            int resultado = prueba.test(cadena);

            // Assert
            Assert.AreEqual(resultado, password);
        }


        // PRUEBA PARA UNA DE TRES VOCALES "abc"
        [TestMethod]
        [DataRow(0)]
        public void PasswordTresVocales(int password)
        {
            // preparacion
            string cadena = "abc";
            ComprobadorDePasswordATMS2324 prueba = new ComprobadorDePasswordATMS2324();

            // funcion a probar
            int resultado = prueba.test(cadena);

            // Assert
            Assert.AreEqual(resultado, password);
        }

        // PRUEBA PARA UNA PASWORDD SEGURA "C0ntr@s3ñ@S3gur@"
        [TestMethod]
        [DataRow(4)]
        public void PasswordSegura(int password)
        {
            // preparacion
            string cadena = "C0ntr@s3ñ@S3gur@";
            ComprobadorDePasswordATMS2324 prueba = new ComprobadorDePasswordATMS2324();

            // funcion a probar
            int resultado = prueba.test(cadena);

            // Assert
            Assert.AreEqual(resultado, password);
        }


    }
}
