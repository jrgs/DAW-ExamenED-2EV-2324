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
        public string Password;

        private bool Minusculas;
        private bool Mayusculas;
        private bool Numeros;
        private bool Longitud;

        public comprobadorDePassword()
        {
            //minusculas = mays = numeros = length = false;
            Minusculas = false;
            Mayusculas = false;
            Numeros = false;
            Longitud = false;
        }

        public int test(string contrasenya)
        {
            Password = contrasenya;

            if (Password == null || Password.Length <= 0)
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error

            if (Password.Length < 6)
                return 0; // No tiene la longitud mínima, error


            bool mins = false;
            bool mays = false;
            bool nums = false;
            bool length = false;

            if (Password.Length > 12)
            {
                length = true;
            }

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
            int fuerzaDeContrasenya = 0;
            if (mins)
            {
                fuerzaDeContrasenya++;
            } 
            if (mays)
            {
                fuerzaDeContrasenya++;
            }
            if (nums)
            {
                fuerzaDeContrasenya++;
            }
            if (length)
            {
                fuerzaDeContrasenya++;
            }
            return fuerzaDeContrasenya;
        }
    }
}
