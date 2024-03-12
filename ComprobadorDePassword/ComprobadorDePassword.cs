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
        public string password;

        private bool minusculas;
        private bool mayusculas;
        private bool numeros;
        private bool length;
        /// <summary>
        /// Esto es el constructor
        /// </summary>
        public comprobadorDePassword()
        {
            minusculas = mayusculas = numeros = length = false;
        }
        /// <summary>
        /// Esto es un método que realizará las comprobaciones sobre la contraseña
        /// </summary>
        /// <param name="contrasenya">contraseña es el parámetro que se introducirá desde el formulario</param>
        /// <returns>Devuelve un valor que indica la fortaleza,siendo 4 muy fuerte y 1 débil</returns>
        /// <exception cref="ArgumentNullException"> Excepción que devuelve cuando se introduce contraseña vacía</exception>
        /// <exception cref="ArgumentOutOfRangeException">Excepción que devuelve cuando se introduce contraseña
        /// de menos de 6 digitos</exception>
        /// <paramref="constrasenya">este parámetro pasa la contraseña recibida en el form</paramref>
        public int Test(string contrasenya)
        {
            
            password = contrasenya;

            if (password == null || password.Length <= 0)
            {
                throw new ArgumentNullException("La contraseña es nula o vacía");
            }
            if (password.Length < 6)
            {
                throw new ArgumentOutOfRangeException("La contraseña es menor a 6 digitos");
            }


            bool minusculas = false;
            bool mayusculas = false;
            bool numeros = false;
            bool length = false;

            if (password.Length > 12) length = true;

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char cadena in password)
            {
                if (char.IsLower(cadena))
                {
                    minusculas = true;
                }
                else if (char.IsUpper(cadena)) 
                    {
                        mayusculas = true;
                    }
                else if (char.IsDigit(cadena))
                    {
                    numeros = true;
                    }
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int fortaleza = 0;
            if (minusculas) fortaleza++;
            if (mayusculas) fortaleza++;
            if (numeros) fortaleza++;
            if (length) fortaleza++;

            return fortaleza;
        }
    }
}
