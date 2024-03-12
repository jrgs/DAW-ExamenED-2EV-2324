using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;

    public class ComprobadorDePassword
    {
        public string password;

        private bool mins;
        private bool mays;
        private bool nums;
        private bool length;

        public ComprobadorDePassword()
        {
            mins = mays = nums = length = false;
        }

        public int Test(string password)
        {
            this.password = password;

            if (this.password == null || this.password.Length <= 0)
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error

            if (this.password.Length < 6)
                return 0; // No tiene la longitud mínima, error


            bool minusculas = false;
            bool mayusculas = false;
            bool numeros = false;
            bool length = false;

            if (this.password.Length > 12) length = true;

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char cadena in this.password)
            {
                if (char.IsLower(cadena))
                {
                    minusculas = true;
                }
            }
            foreach (char cadena in this.password)
            {
                if (char.IsUpper(cadena))
                {
                    mayusculas = true;
                }
            }
            foreach (char cadena in this.password)
            {
                if (char.IsDigit(cadena))
                {
                    numeros = true;
                }
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int f = 0;
            if (minusculas) f++;
            if (mayusculas) f++;
            if (numeros) f++;
            if (length) f++;

            return f;
        }
    }
}
