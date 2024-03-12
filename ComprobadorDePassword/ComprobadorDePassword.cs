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
        private const int longitudMinima = 6;
        private const int longitudExtraFuerza = 12;
        private const int error = -1;

        private string password;

        private bool minusculas;
        private bool mayusculas;
        private bool numeros;
        private bool largo;

        public string Password { get => password; set => password = value; }

        /// <summary>
        /// Constructor predeterminado que establece en falso todas las variables.
        /// </summary>
        public comprobadorDePassword()
        {
            minusculas = mayusculas = numeros = largo = false;
        }

        /// <summary>
        /// Metodo que permite verificar la "fuerza de una contraseña".
        /// </summary>
        /// <param name="contraseña">Haceta una contraseña de como minimo <remarks>6 caracteres</remarks></param>
        /// <returns>Devuelve 0 para errores, 1 para contraseña debil, 2 para contraseña normal, 3 para contraseña fuerte
        /// y 4 para contraseñas muy fuertes</returns>
        /// <code>comprobadorDePassword miComprobador = new comprobadorDePassword(); miComprobador.Test("ContraseñaS5guRa")</code>
        public int Test(string contraseña)
        {

            if (contraseña == null || contraseña.Length <= 0)
                return error; // Si la contraseña es nula o vacía, devolvemos un código de error

            if (contraseña.Length < longitudMinima)
                return longitudMinima; // No tiene la longitud mínima, error

            bool minusculas = false;
            bool mayusculas = false;
            bool numeros = false;
            bool largo = false;

            if (contraseña.Length > longitudExtraFuerza)
            {
                largo = true;
            }
            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            minusculas = TieneMinuscula(contraseña);
            mayusculas = TieneMayuscula(contraseña);
            numeros = TieneNumero(contraseña);

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int fuerza = 0;
            if (minusculas)
                fuerza++;
            if (mayusculas)
                fuerza++;
            if (numeros)
                fuerza++;
            if (largo)
                fuerza++;
            return fuerza;
        }

        private bool TieneMinuscula(string contraseña)
        {
            foreach (char letra in contraseña)
            {
                if (char.IsLower(letra))
                {
                    minusculas = true;
                }
            }

            return minusculas;
        }

        private bool TieneMayuscula(string contraseña)
        {
            foreach (char letra in contraseña)
            {
                if (char.IsUpper(letra))
                {
                    mayusculas = true;
                }
            }

            return mayusculas;
        }

        private bool TieneNumero(string contraseña)
        {
            foreach (char letra in contraseña)
            {
                if (char.IsDigit(letra))
                {
                    numeros = true;
                }
            }

            return numeros;
        }
    }
}
