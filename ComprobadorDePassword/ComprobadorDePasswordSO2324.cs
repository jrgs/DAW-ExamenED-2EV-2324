using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword2324
{
    using System;
    using System.Text.RegularExpressions;
    /// <summary>
    /// La clase que compruebe el nivel de la fuerza de la contraseña.
    /// </summary>
    /// <valor>
    /// Devuelve un valor, que corresponde al nivel de la fuerza de la contraseña:
    ///     <list type="table">
    ///         <item>
    ///             <description>-1 - contraseña vacía</description>
    ///         </item>
    ///         <item>
    ///             <description>0 - contraseña no cumple los requisitos mínimos de seguridad</description>
    ///         </item>
    ///         <item>
    ///             <description>1 - contraseña débil</description>
    ///         </item>
    ///         <item>
    ///             <description>3 - contraseña normal</description>
    ///         </item>
    ///         <item>
    ///             <description>3 - contraseña fuerte</description>
    ///         </item>
    ///         <item>
    ///             <description>4 - contraseña muy fuerte</description>
    ///         </item>
    ///     </list>
    /// </valor>
    public class ComprobadorDePasswordSO2324
    {
        public string password;
        /// <summary>
        /// Propiedad de la clase, que muestra, si la contraseña tiene minúsculas.
        /// </summary>
        private bool minusculas;
        /// <summary>
        /// Propiedad de la clase, que muestra, si la contraseña tiene mayúsculas.
        /// </summary>
        private bool mayusculas;
        /// <summary>
        /// Propiedad de la clase, que muestra, si la contraseña tiene símbolos numéricos.
        /// </summary>
        private bool numeros;
        /// <summary>
        /// Propiedad de la clase, que tiene el valor de la longitud de la contraseña.
        /// </summary>
        private bool longitud;
        /// <summary>
        /// Función constructora de la clase
        /// </summary>
        public bool Minusculas { get => minusculas; set => minusculas=value; }
        public bool Mayusculas { get => mayusculas; set => mayusculas=value; }
        public bool Numeros { get => numeros; set => numeros=value; }
        public bool Longitud { get => longitud; set => longitud=value; }
        public ComprobadorDePasswordSO2324()
        {
            minusculas = false;
            mayusculas = false;
            numeros = false;
            longitud = false;
        }
        /// <summary>
        /// El método de la clase, compruebe la fuerza de la contraseña dada
        /// </summary>
        /// <param name="contrasenya"></param>
        /// <returns>Devuelve un valor, que corresponde al nivel de la fuerza de la contraseña</returns>
        public int test(string contrasenya)
        {
            password = contrasenya;

            if (password == null || password.Length <= 0)
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error

            if (password.Length < 6)
                return 0; // No tiene la longitud mínima, error


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
