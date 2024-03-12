using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public class ComprobadorDePasswordEEGS2324
    {
        
        public string password; 

        private bool minuscula;
        private bool mayuscula;
        private bool numeros;
        private bool longitud;
        private const string PASSWORD_SIN_CARACTERES = "El password no tiene caracteres";
        private const string PASSWORD_CORTO = "El password no es válido";

        public bool Minuscula 
        
        {
            get { return minuscula; }

            set { minuscula = value; }
        }
        public bool Mayuscula 
        {
            get { return mayuscula; }

            set { mayuscula = value; }
        }
        public bool Numeros 
        {
            get { return numeros; }

            set { numeros = value; }
        }
        public bool Longitud 
        {
            get { return longitud; }

            set { longitud = value; }
        }

        public ComprobadorDePasswordEEGS2324()
        {
            Minuscula = false;
            Mayuscula = false;
            Numeros = false;
            Longitud = false;
        }

        private bool ContrasenyaValidar(string password)
        {
            bool correcto = true;

            if (this.password == null || this.password.Length <= 0)
                throw new Exception(PASSWORD_SIN_CARACTERES); // Si la contraseña es nula o vacía, devolvemos un código de error

            if (this.password.Length < 6)
                throw new Exception(PASSWORD_CORTO); // No tiene la longitud mínima, error

            return correcto;
        }

        public int Test(string password)
        {
            this.password = password;

            try
            {
                bool passwordValida = ContrasenyaValidar(password);
                
            } catch (Exception e)
            {
                if (e.Message == PASSWORD_SIN_CARACTERES)
                {
                    MessageBox.Show("El password no tiene caracteres");
                    return -1;
                }

                else
                {
                    MessageBox.Show("El password es corto");
                    return 0;
                }
            }
            

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
