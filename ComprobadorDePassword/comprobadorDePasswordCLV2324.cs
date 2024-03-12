using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;

    public class ComprobadorDePasswordCLV2324
    {
        public string pwd;
        public bool mins;
        public bool mays;
        public bool nums;
        public bool length;

        public ComprobadorDePasswordCLV2324()
        {
            mins = mays = nums = length = false;
        }

        public int Test(string p)
        {
            pwd = p;

            if (pwd==null || pwd.Length<=0)
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error

            if (pwd.Length < 6)
                return 0; // No tiene la longitud mínima, error


            bool lowerCase = false;
            bool upperCase = false;
            bool numbers = false;
            bool length = false;

            if (pwd.Length > 12) length = true;

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in pwd)
            {
                if (char.IsLower(c))
                {
                    lowerCase=true;
                }
            }
            foreach (char c in pwd)
            {
                if (char.IsUpper(c))
                {
                    upperCase=true;
                }
            }
            foreach (char c in pwd)
            {
                if (char.IsDigit(c))
                {
                    numbers=true;
                }
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int f=0;
            if (lowerCase) f++;
            if (upperCase) f++;
            if (numbers) f++;
            if (length) f++;

            return f;
        }
    }
}
