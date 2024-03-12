using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;

    public class ComprobadorDePasswordAPG2324
    {
        public string contrasenya;

        private bool minusculas;
        private bool mayusculas;
        private bool numeros;
        private bool longitud;

        public ComprobadorDePasswordAPG2324()
        {
            minusculas = mayusculas = numeros = longitud = false;
        }

        public int Test(string p)
        {
            contrasenya = p;

            if (contrasenya == null || contrasenya.Length <= 0)
            {
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error
            }

            if (contrasenya.Length < 6)
                return 0; // No tiene la longitud mínima, error


            bool mins = false;
            bool mays = false;
            bool nums = false;
            bool length = false;

            if (contrasenya.Length > 12)
            {
                length = true;
            }

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in contrasenya)
            {
                if (char.IsLower(c))
                {
                    mins=true;
                }
            }

            foreach (char c in contrasenya)
            {
                if (char.IsUpper(c))
                {
                    mays=true;
                }
            }

            foreach (char c in contrasenya)
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
