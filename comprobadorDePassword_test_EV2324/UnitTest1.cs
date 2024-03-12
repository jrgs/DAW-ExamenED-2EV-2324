using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.Contracts;
using ComprobadrDePassword;

namespace comprobadorDePassword_test_EV2324
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow ("contras")]
        [DataRow("c0ntrase")]
        [DataRow("C0ntr@s3ñ@S3gur@)")]

        public void ComprobarPassword(string password)
        {
            comprobadorDePassword comprobadorDePassword = new comprobadorDePassword();
            comprobadorDePassword.Comprobar 
        }
    }
}
