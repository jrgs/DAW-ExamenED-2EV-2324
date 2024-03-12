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
        private string contraseña;

        private bool mins;
        private bool mays;
        private bool nums;
        private bool length;

        public string Contraseña { get => contraseña; set => contraseña = value; }

        public comprobadorDePassword()
        {
            mins = mays = nums = length = false;
        }



        public int ProbarContraseña(string p)
        {
            Contraseña = p;
            bool mins = false;
            bool mays = false;
            bool nums = false;
            bool length = false;

            if (Contraseña == null || Contraseña.Length <= 0)
            {
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error
            }


            if (Contraseña.Length < 6)
            {
                return 0; // No tiene la longitud mínima, error
            }





            if (Contraseña.Length > 12)
            {
                length = true;
            }

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in Contraseña)
            {
                if (char.IsLower(c))
                {
                    mins = true;
                }
            }
            foreach (char c in Contraseña)
            {
                if (char.IsUpper(c))
                {
                    mays = true;
                }
            }
            foreach (char c in Contraseña)
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
