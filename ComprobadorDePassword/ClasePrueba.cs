using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    internal class ClasePrueba
    {
        [TestMethod]    //KEJ 
        public void ContraseñaVacia()
        {
            string contraseña = "";
            int resultado = -1;
            ComprobadorDePassword miAplicacion = new comprobadorDePassword();
            miAplicacion.Test(contraseña);

            Assert.AreEqual(resultado, miAplicacion.Test(contraseña));
        }

        [TestMethod]    //KEJ
        public void ContraseñaDemasiadoCorta()
        {
            string contraseña = "abc";
            int resultado = 0;

            ComprobadorDePassword miAplicacion = new comprobadorDePassword();
            miAplicacion.Test(contraseña);

            Assert.AreEqual(resultado, miAplicacion.Test(contraseña));
        }

        [TestMethod]    //KEJ
        public void ContraseñaFuerte()
        {
            string contraseña = "C0ntr@s3ñ@S3gur@";
            int resultado = 4;

            ComprobadorDePassword miAplicacion = new comprobadorDePassword();
            miAplicacion.Test(contraseña);

            Assert.AreEqual(resultado, miAplicacion.Test(contraseña));
        }

    }

}
}
