using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;

    public class ComprobadorDePasswordMMA2324
    {
        private string password;
        private bool minusculas;
        private bool mayusculas;
        private bool numeros;
        private bool passwordLength;
        public string ERROR_PASSWORD_VACIO = "La contraseña no puede estar vacía.";
        public string ERROR_PASSWORD_MENOR6 = "Contraseña demasiado corta";

        /// <summary>
        /// <para>Constructor que inicializa los campos que formarán parte de <see cref="password"/>.</para>
        /// <para>Los campos son:
        /// <list type="bullet">
        ///     <item>
        ///         <decription>Minusculas</decription>
        ///     </item>
        ///     <item>
        ///         <description>Mayúsculas</description>
        ///     </item>
        ///     <item>
        ///         <descripton>Números</descripton>
        ///     </item>
        ///     <item>
        ///         <description>Longitud del password</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        /// <remarks>Inicializa todos los campos a false.</remarks>
        public ComprobadorDePasswordMMA2324()
        {
            minusculas = mayusculas = numeros = passwordLength = false;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        /// <summary>
        /// <para>Método que valida el string <paramref name="password"/>.</para>
        /// <para>Valida si la contraseña tiene la longitud adecuada, y determina el nivel de fortaleza de la misma analizando su contenido (mayúsculas),
        /// minúsculas, números y longitud mayor que 12.</para>
        /// </summary>
        /// <param name="password">Valor de tipo string que representa la contraseña que vamos a validar.</param>
        /// <returns>Entero de tipo int que refleja el nivel de fortaleza que tiene <paramref name="password"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">String password vacío o String con longitud menor que 6.</exception>
        /// <remarks>El mensaje que generará la excepción ERROR_PASSWORD_VACIO será "La contraseña no puede estar vacía.</remarks>
        /// <remarks>El mensaje que generará la excepción ERROR_PASSWORD_MENOR6 será "Contraseña demasiado corta"</remarks>
        public int TestValidacionPassword(string password)
        {
            Password = password;

            if (Password == null || Password.Length <= 0)
            {
                throw new ArgumentOutOfRangeException(ERROR_PASSWORD_VACIO);
            }

            if (Password.Length < 6)
            {
                throw new ArgumentOutOfRangeException(ERROR_PASSWORD_MENOR6);
            }

            bool mins = false;
            bool mays = false;
            bool nums = false;
            bool length = false;

            if (Password.Length > 12) length = true;

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            foreach (char caracter in Password)
            {
                if (char.IsLower(caracter))
                {
                    mins = true;
                }
            }

            foreach (char caracter in Password)
            {
                if (char.IsUpper(caracter))
                {
                    mays = true;
                }
            }

            foreach (char caracter in Password)
            {
                if (char.IsDigit(caracter))
                {
                    nums = true;
                }
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int nivelFortaleza = 0;

            if (mins)
            {
                nivelFortaleza++;
            }

            if (mays)
            {
                nivelFortaleza++;
            }

            if (nums)
            {
                nivelFortaleza++;
            }

            if (length)
            {
                nivelFortaleza++;
            }

            return nivelFortaleza;
        }
    }
}
