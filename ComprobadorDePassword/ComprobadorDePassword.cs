using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;

    public class ComprobadorDePassword
    {
        private string password;
        private bool minusculas;
        private bool mayusculas;
        private bool numeros;
        private bool length;
        public const String ERR_CLAVE_NULA_O_VACIA = "error, clave nula o vacia";
        public const String ERR_CLAVE_MUY_CORTA = "error, clave corta";

        /// <summary>
        /// Constructor de clase. Sirve para inicializar la clase.
        /// </summary>
        public ComprobadorDePassword()
        {
            Minusculas = Mayusculas = Numeros = Length = false;
        }

        public bool Minusculas { get => minusculas; set => minusculas = value; }
        public bool Mayusculas { get => mayusculas; set => mayusculas = value; }
        public bool Numeros { get => numeros; set => numeros = value; }
        public bool Length { get => length; set => length = value; }
        public string Password { get => password; set => password = value; }


        /// <summary>
        /// Metodo por el cual pasamos una contraseña
        /// </summary>
        /// <param name="password">contraseña que introduce el usuario</param>
        /// <returns>Nos devuelve -1, 0 o fortaleza de la contraseña</returns>
        public int Test(string password)
        {
            this.Password = password;
            ///<summary>Si la contraseña es nula o vacía, devolvemos un código de error</summary>
            if (this.Password == null || this.Password.Length <= 0)
                throw new ArgumentOutOfRangeException(ERR_CLAVE_NULA_O_VACIA);
            ///<summary>Si no tiene la longitud mínima, error</summary>
            if (this.Password.Length < 6)
                throw new ArgumentOutOfRangeException(ERR_CLAVE_MUY_CORTA);


            bool minusculas = false;
            bool mayusculas = false;
            bool numeros = false;
            bool length = false;

            ///<summary>Si longitud es mayor que 12, length será true</summary>
            if (this.Password.Length > 12) length = true;

            ///<summary>Recorremos la cadena para ver si existen minúsculas, mayúsculas y números</summary>
            foreach (char cadena in this.Password)
            {
                if (char.IsLower(cadena))
                {
                    minusculas = true;
                }
                if (char.IsUpper(cadena))
                {
                    mayusculas = true;
                }
                if (char.IsDigit(cadena))
                {
                    numeros = true;
                }
            }
            ///<summary>Calculamos el nivel de fortaleza</summary>
            ///<returns>
            ///<para>4: muy fuerte</para>
            ///<para>3: fuerte</para>
            ///<para>2: normal</para>
            ///<para>1: debil</para>
            /// </returns>
            int f = 0;
            if (minusculas) f++;
            if (mayusculas) f++;
            if (numeros) f++;
            if (length) f++;

            return f;
        }
    }
}