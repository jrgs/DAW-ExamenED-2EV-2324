using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;

    public class ComprobadorDePasswordEEGS2324
    {
        
        public string password; 

        private bool minuscula;
        private bool mayuscula;
        private bool numeros;
        private bool longitud;

        public ComprobadorDePasswordEEGS2324()
        {
            minuscula = false;
            mayuscula = false;
            numeros = false;
            longitud = false;
        }

        public int Test(string password)
        {
            this.password = password;

            if (this.password == null || this.password.Length <= 0)
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error

            if (this.password.Length < 6)
                return 0; // No tiene la longitud mínima, error


            bool minuscula = false;
            bool mayuscula = false;
            bool numeros = false;
            bool longitud = false;

            if (this.password.Length > 12) 
                
                longitud = true;

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char caracter in this.password)
            {
                if (char.IsLower(caracter))
                {
                    minuscula=true;
                }
            }
            foreach (char caracter in this.password)
            {
                if (char.IsUpper(caracter))
                {
                    mayuscula=true;
                }
            }
            foreach (char caracter in this.password)
            {
                if (char.IsDigit(caracter))
                {
                    numeros=true;
                }
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int fortaleza=0;

            if (minuscula) 
                fortaleza++;

            if (mayuscula) 
                fortaleza++;

            if (numeros) 
                fortaleza++;

            if (longitud) 
                fortaleza++;

            return fortaleza;
        }
    }
}
