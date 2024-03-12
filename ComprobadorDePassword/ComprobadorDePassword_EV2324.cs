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
        //EV2324
        public string _password;

        private bool _minusculas;
        private bool _mayusculas;
        private bool _numeros;
        private bool _longitud;

        public comprobadorDePassword()
        {
            _minusculas = _mayusculas = _numeros = _longitud = false;
        }

        public int Comprobar(string contrasenya)
        {
            _password = contrasenya;

            if (_password == null || _password.Length <= 0)
            {
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error
            }


            if (_password.Length < 6)
            {
                return 0; // No tiene la longitud mínima, error
            }

            int fuerte = ComprobarFortaleza();

            return fuerte;
        }

        private int ComprobarFortaleza()
        {
            bool minusculas = false;
            bool mayusculas = false;
            bool numeros = false;
            bool longitud = false;

            if (_password.Length > 12) longitud = true;

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in _password)
            {
                if (char.IsLower(c))
                {
                    minusculas = true;
                }
            }
            foreach (char c in _password)
            {
                if (char.IsUpper(c))
                {
                    mayusculas = true;
                }
            }
            foreach (char c in _password)
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
            int fuerte = 0;
            if (minusculas) fuerte++;
            if (mayusculas) fuerte++;
            if (numeros) fuerte++;
            if (longitud) fuerte++;
            return fuerte;
        }
    }
}
