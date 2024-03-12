using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;

    public class comprobadorDePassword
    {
        public string password;

        private bool minusculas;
        private bool mayusculas;
        private bool numeros;
        private bool length;

        public comprobadorDePassword()
        {
            minusculas = mayusculas = numeros = length = false;
        }

        public int Test(string contrasenya)
        {
            password = contrasenya;

            if (password == null || password.Length <= 0)
            {
                throw new ArgumentNullException("La contraseña es nula o vacía");
            }
            if (password.Length < 6)
            {
                throw new ArgumentNullException("La contraseña es nula o vacía");
            }


            bool minusculas = false;
            bool mayusculas = false;
            bool numeros = false;
            bool length = false;

            if (password.Length > 12) length = true;

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char cadena in password)
            {
                if (char.IsLower(cadena))
                {
                    minusculas = true;
                }
                else if (char.IsUpper(cadena)) 
                    {
                        mayusculas = true;
                    }
                else if (char.IsDigit(cadena))
                    {
                    numeros = true;
                    }
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int fortaleza = 0;
            if (minusculas) fortaleza++;
            if (mayusculas) fortaleza++;
            if (numeros) fortaleza++;
            if (length) fortaleza++;

            return fortaleza;
        }
    }
}
