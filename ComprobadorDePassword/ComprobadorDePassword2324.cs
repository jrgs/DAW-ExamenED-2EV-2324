using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System;

namespace ComprobadorDePassword
{
    public class ComprobadorDePassword
    {
        private string password;
        private bool tieneMinusculas;
        private bool tieneMayusculas;
        private bool tieneNumeros;
        private bool tieneLongitudValida;

        public ComprobadorDePassword()
        {
            tieneMinusculas = tieneMayusculas = tieneNumeros = tieneLongitudValida = false;
        }

        public int Probar(string nuevaContraseña)
        {
            password = nuevaContraseña;

            if (string.IsNullOrEmpty(password))
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error

            if (password.Length < 6)
                return 0; // No tiene la longitud mínima, error

            tieneMinusculas = false;
            tieneMayusculas = false;
            tieneNumeros = false;
            tieneLongitudValida = password.Length > 12;

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            foreach (char c in password)
            {
                if (char.IsLower(c))
                    tieneMinusculas = true;
                else if (char.IsUpper(c))
                    tieneMayusculas = true;
                else if (char.IsDigit(c))
                    tieneNumeros = true;
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int fortaleza = 0;
            if (tieneMinusculas) fortaleza++;
            if (tieneMayusculas) fortaleza++;
            if (tieneNumeros) fortaleza++;
            if (tieneLongitudValida) fortaleza++;

            return fortaleza;
        }
    }
}
