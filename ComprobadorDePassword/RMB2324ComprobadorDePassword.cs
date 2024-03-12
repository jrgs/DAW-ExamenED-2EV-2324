using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;

    public class RMB2324ComprobadorDePassword
    {
        //RMB2324 Encapsular campo
        private string password;

        //RMB2324 Poner nombres autoexplicativos
        private bool minúsculas;
        private bool mayúsculas;
        private bool números;
        private bool length;

        //RMB2324 Declarar constantes
        public const string ERR_CONTRASEÑA_NULA_O_VACIA = "";
        public const string ERR_CONTRASEÑA_CORTA = "";

        public RMB2324ComprobadorDePassword()
        {
            try
            {
                minúsculas = mayúsculas = números = length = false;
            }
            catch (ArgumentOutOfRangeException error)
            {
                throw new ArgumentOutOfRangeException(error.Message);
            }
        }

        public string Password { get => password; set => password = value; }

        //RMB2324 Los nombres de los métodos deben ser PasCal
        public int Test(string p)
        {
            Password = p;

            //RMB2324 Se declaran las variables al inicio del método
            bool mins = false;
            bool mays = false;
            bool nums = false;
            bool length = false;

            // RMB2324 Se incluyen las llaves
            if (Password==null || Password.Length <= 0)
            {
                //RMB2324 Se sustituyen los números mágicos por las constantes
                throw new ArgumentOutOfRangeException(ERR_CONTRASEÑA_NULA_O_VACIA);
            }
                
            if (Password.Length < 6)
            {
                throw new ArgumentOutOfRangeException(ERR_CONTRASEÑA_CORTA);
            }

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
                    mins=true;
                }
            }
            foreach (char c in Password)
            {
                if (char.IsUpper(c))
                {
                    mays=true;
                }
            }
            foreach (char c in Password)
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
