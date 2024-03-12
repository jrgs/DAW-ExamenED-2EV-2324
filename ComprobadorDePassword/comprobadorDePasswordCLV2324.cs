using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
///<summary>
/// <para>Clase que comprueba passwords</para>
///</summary>
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
        /// <summary>
        /// booleanos que comprueban si hay minúsculas, mayúsculas, longitud y números
        /// </summary>

        public ComprobadorDePasswordCLV2324()
            ///<summary>Esta clase muestra por booleado si la contraseña suma las carácterísticas para ser segurass
            ///</summary>
        {
            mins = mays = nums = length = false;
        }

        public int Test(string p)
            ///<summary>
            ///Cuando las contraseñas son nulas, están vacías o no tienen la longitud pedida, se devuelve un mensaje de error
            ///</summary>
            
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
            ///<summary>
            ///Si la longitud es mayor a 12 caracteres, será válida
            ///</summary>
            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in pwd)
                ///<summary>
                ///Comprobación de minúsculas y mayúsculas
                ///</summary>
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
            ///<summary>Cálculo de la fortaleza de la contraseña
            /// <para>El valor del int f=0; indica condicionales en cuanto a la fortaleza de la contraseña</para>
            ///</summary>
            int f =0;
            if (lowerCase) f++;
            if (upperCase) f++;
            if (numbers) f++;
            if (length) f++;

            return f;
        }
    }
}
