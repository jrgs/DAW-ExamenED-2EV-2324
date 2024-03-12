using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{   
    
    using System;
    using System.Text.RegularExpressions;
   
    
    private const int Pws_Vacia = 0;
    private const int Pws_Minima = 6;
    private const int Pws_Protegida = 12;

    ///<summary>
    ///El programa va a realizar la comprobacion de contraselñas introducidas
    ///</summary>

    public class Examen2EVDRL2324
    {
        public string pwd;

        private bool minusculas;
        private bool mayu;
        private bool nums;
        private bool length;

        ///<summary>
        ///En este metodo cambia el valor de las variables
        ///</summary>
        ///<returns>Devuleve el valor false</returns>
        public comprobadorDePassword()
        {
            minusculas = mays = nums = length = false;
        }

        ///<summary>
        ///Realizamos la comprnacion de los valores de la contraseñas
        ///</summary>
        ///<remarks>El metodo esta sobrecargado</remarks>
        ///<returns>Nos devuelve el nivel de protecion de la contraseña</returns>
        ///<param value="Islover>Parametro que indica si tiene caracteres en minuscula</param>
        ///<param value="IsUpper>Parametro que indica si tiene caracteres en mayuscula</param>
        ///<param value="Islover>Parametro que indica si contiene caracteres de digitos</param>
        public int test(string p)
        {
            pwd = p;

            if (pwd == null || pwd.Length <= Pws_Vacia)
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error

            if (pwd.Length < Pws_Minima)
                return 0; // No tiene la longitud mínima, error

            comprobadorDePassword();

            if (pwd.Length > Pws_Protegida) length = true;

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in pwd)
            {
                if (char.IsLower(c))
                {
                    minusculas = true;
                }
            }
            foreach (char c in pwd)
            {
                if (char.IsUpper(c))
                {
                    mays = true;
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
            int f = 0;
            if (minusculas) f++;
            if (mays) f++;
            if (nums) f++;
            if (length) f++;

            return f;
        }
    }
}
