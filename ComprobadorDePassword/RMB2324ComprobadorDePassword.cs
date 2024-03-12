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
        public const string ERR_CONTRASEÑA_NULA_O_VACIA = "La contraseña no puede estar vacía.";
        public const string ERR_CONTRASEÑA_CORTA = "La contraseña es demasiado corta.";

        /// <summary>
        /// <para> Constructor por defecto de la clase.</para>
        /// <para> Los parámetros se inicializan a false.</para>
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">Devuelve un mensaje en función deltipo de error</exception>
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


        /// <summary>
        /// Dada una constraseña devuelve si es válida o su fortaleza.
        /// </summary>
        /// <param name="password">Valor tipo string que representa una contraseña.</param>
        /// <returns>La fortaleza de la constraseña.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">La contraseña no puede estar vacía.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">La contraseña es demasiado corta.</exception>
        public int Test(string password)
        {
            Password = password;

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
