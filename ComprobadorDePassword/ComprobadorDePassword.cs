using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePasswordJPP2324
{
    using System;
    using System.Text.RegularExpressions;

    public class comprobadorDePasswordJPP234
    {
        public const string CONTRASEÑAINCORRECTA = "La contraseña introducida no es valida";
        public const string CONTRASEÑAVACIA = "lA contraseña no puede quedarse vacia.";

        private string pwd;
        private bool mins;
        private bool mays;
        private bool nums;
        private bool length;

        public comprobadorDePasswordJPP2324(string contraseña)
        {
            contraseña = "";
            mins = mays = nums = length = false;
            
        }

        public string Pwd
        {   get => pwd; 
            set => pwd = value;
        }
        public bool Mins {
            get => mins; 
            set => mins = value;
        }
        public bool Mays 
        { get => mays; 
            set => mays = value;
        }
        public bool Nums 
        { get => nums;
            set => nums = value;
        }
        public bool Length 
        { get => length; 
            set => length = value;
        }

        public int ValidacionContraseña(string p)
        {
            pwd = p;

            if (pwd==null || pwd.Length<=0)
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error

            if (pwd.Length < 6)
                return 0; // No tiene la longitud mínima, error


            bool mins = false;
            bool mays = false;
            bool nums = false;
            bool length = false;

            if (pwd.Length > 12) length = true;

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in pwd)
            {
                if (char.IsLower(c))
                {
                    mins=true;
                }
            }
            foreach (char c in pwd)
            {
                if (char.IsUpper(c))
                {
                    mays=true;
                }
            }
            foreach (char c in pwd)
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
            if (mins) f++;
            if (mays) f++;
            if (nums) f++;
            if (length) f++;

            return f;
        }
    }
}
