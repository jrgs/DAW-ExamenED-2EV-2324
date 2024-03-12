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
        public string password;

        private bool minusculas;
        private bool mayusculas;
        private bool numeros;
        private bool tamanyoPassword;

        public ComprobadorDePasswordCDJ2324()
        {
            minusculas = mayusculas = numeros = tamanyoPassword = false;
        }

        public int ComprobadorDePasswordTest(string p)
        {
            password = p;

            if (password==null || password.Length<=0)
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error

            if (password.Length < 6)
                return 0; // No tiene la longitud mínima, error


            bool mins = false;
            bool mays = false;
            bool nums = false;
            bool length = false;

            if (password.Length > 12) length = true;

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    mins=true;
                }
            }
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    mays=true;
                }
            }
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    nums=true;
                }
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int f=0;
            if (mins) f++;
            if (mays) f++;
            if (nums) f++;
            if (length) f++;

            return f;
        }
    }
}
