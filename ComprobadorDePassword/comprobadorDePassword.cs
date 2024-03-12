using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;

    public class ComprobadorDePasswordATMS2324
    {
        public string password;

        private bool minusculas;
        private bool mayusculas;
        private bool numeros;
        private bool longitud;

        public ComprobadorDePasswordATMS2324()
        {
            minusculas = false;
            mayusculas = false;
            numeros = false; 
            longitud = false;
        }

        public int test(string p)
        {
            password = p;

            if (password == null || password.Length <= 0)
                { 
                    return -1; // Si la contraseña es nula o vacía, devolvemos un código de error
                }
            if (password.Length < 6)
                { 
                    return 0; // No tiene la longitud mínima, error
                }

            bool mins = false;
            bool mays = false;
            bool nums = false;
            bool length = false;

            if (password.Length > 12)
            {
                length = true;
            }

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    mins = true;
                }
            }
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    mays = true;
                }
            }
            foreach (char c in password)
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
            int fortaleza=0;
            if (mins)
            {
                fortaleza++;
            }
            if (mays)
            {
                fortaleza++;
            }
            if (nums)
            {
                fortaleza++;
            }
            if (length)
            {
                fortaleza++;
            }

            return fortaleza;
        }
    }
}
