using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;

    public class ComprobadorDePasswordMMA2324
    {
        private string password;
        private bool minusculas;
        private bool mayusculas;
        private bool numeros;
        private bool passwordLength;
        public string ERROR_PASSWORD_VACIO = "La contraseña no puede estar vacía.";
        public string ERROR_PASSWORD_MENOR6 = "Contraseña demasiado corta";

        public ComprobadorDePasswordMMA2324()
        {
            minusculas = mayusculas = numeros = passwordLength = false;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public int TestValidacionPassword(string password)
        {
            Password = password;

            if (Password == null || Password.Length <= 0)
            {
                throw new ArgumentOutOfRangeException(ERROR_PASSWORD_VACIO);
            }

            if (Password.Length < 6)
            {
                throw new ArgumentOutOfRangeException(ERROR_PASSWORD_MENOR6);
            }

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
            int f=0;

            if (mins)
            {
                f++;
            }

            if (mays)
            {
                f++;
            }

            if (nums)
            {
                f++;
            }

            if (length)
            {
                f++;
            }

            return f;
        }
    }
}
