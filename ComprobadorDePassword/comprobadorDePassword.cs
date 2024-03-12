using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;

    public class ComprobadorDePasswordATMS2324
    {
        private string password;
        public const int passwordNula = -1;
        public const int passwordInferior = 0;

        private bool minusculas;
        private bool mayusculas;
        private bool numeros;
        private bool longitud;

        public ComprobadorDePasswordATMS2324()
        {
            minusculas = false;
            mayusculas = false;
            numeros = false; 
            longitud = false;
        }

        public string Password 
        { 
            get => password; 
            set => password = value; 
        }

        public int Test(string p)
        {
            Password = p;

            if (Password == null || Password.Length <= 0)
                { 
                    return passwordNula; // Si la contraseña es nula o vacía, devolvemos un código de error
                }
            if (Password.Length < 6)
                { 
                    return passwordInferior; // No tiene la longitud mínima, error
                }

            //bool minusculas = false;
            //bool mayusculas = false;
            //bool numeros = false;
            //bool longitud = false;

            if (Password.Length > 12)
            {
                longitud = true;
            }

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in Password)
            {
                if (char.IsLower(c))
                {
                    minusculas = true;
                }
            }
            foreach (char c in Password)
            {
                if (char.IsUpper(c))
                {
                    mayusculas = true;
                }
            }
            foreach (char c in Password)
            {
                if (char.IsDigit(c))
                {
                    numeros = true;
                }
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int fortaleza=0;
            if (minusculas)
            {
                fortaleza++;
            }
            if (mayusculas)
            {
                fortaleza++;
            }
            if (numeros)
            {
                fortaleza++;
            }
            if (longitud)
            {
                fortaleza++;
            }

            return fortaleza;
        }
    }
}
