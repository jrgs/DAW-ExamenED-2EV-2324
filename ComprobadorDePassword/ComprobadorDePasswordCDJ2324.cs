using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;

    public class ComprobadorDePasswordCDJ2324
    {
        private string password;

        private bool minusculas;
        private bool mayusculas;
        private bool numeros;
        private bool tamanyoPassword;
        public const string PASSWORD_CORTA = "contraseña corta";
        public const string PASS_NULA = "password nula";

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public ComprobadorDePasswordCDJ2324()
        {
            minusculas = mayusculas = numeros = tamanyoPassword = false;
        }

        public string Password 
        { 
            get => password; 
            set
            {
                if (SetPassword() > 0)
                {
                    password = value;
                }

            }
                 
        }

        /// <summary>
        /// metodo para comprobar si la contraseña ingresada es correcta
        /// </summary>
        /// <param name="password">constraseña tipo string</param>
        /// <returns></returns>
        public int ComprobadorDePasswordTest(string password)
        {
            Password = password;

            return SetPassword();

        }

        public int SetPassword()
        {
            if (Password == null || Password.Length <= 0)
                throw new ArgumentNullException(PASS_NULA); // Si la contraseña es nula o vacía, devolvemos un código de error

            if (Password.Length < 6)
                throw new ArgumentOutOfRangeException(PASSWORD_CORTA); // No tiene la longitud mínima, error


            bool mins = false;
            bool mays = false;
            bool nums = false;
            bool length = false;

            if (Password.Length > 12) length = true;

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in Password)
            {
                if (char.IsLower(c))
                {
                    mins = true;
                }
            }
            foreach (char c in Password)
            {
                if (char.IsUpper(c))
                {
                    mays = true;
                }
            }
            foreach (char c in Password)
            {
                if (char.IsDigit(c))
                {
                    nums = true;
                }
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int f = 0;
            if (mins) f++;
            if (mays) f++;
            if (nums) f++;
            if (length) f++;

            return f;
        }
    }
}
