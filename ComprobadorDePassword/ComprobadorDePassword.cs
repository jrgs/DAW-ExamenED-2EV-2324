using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.CodeDom;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public class comprobadorDePasswordAERG2324
    {//AERG-2324.Se cambia a propiedad de  publica a privada

        private string password;//! AERG-2324.Nombres no significativo
        private const int numerodoce = 12;//! AERG-2324. Declaramos las constantes
        private const int numeroseis = 6;
        private bool minusculas;
        private bool maysculas;
        private bool numeros;
        private bool length;

        public comprobadorDePasswordAERG2324()
        {
            //!AERG-2324.Se enumeran en diferentes lineas

            minusculas = false;
            maysculas = false;
            numeros = false;
            length = false;
        }

        public string Password
        {
             get => password; 
             set => password = value; 
        }

        public int test(string palabra)//! AERG-2324.Se cambia el nombre por ser poco significativo 
        {
            Password = palabra;

            if (Password==null || Password.Length<=0)
                //! AERG-22324. Cambiamos el valor -1 por un numero mágico
              return -1; // Si la contraseña es nula o vacía, devolvemos un código de error

            if (Password.Length < numeroseis)//!AERG-2324. Cambiamos el numero por ser numero mágico por una constante
                return 0; // No tiene la longitud mínima, error

            
            bool minusculas = false;//! AERG-2324.Cambiamos de nuevo los nombres de delos campos 
            bool mayusculas = false;
            bool numeros = false;
            bool length = false;
            // AERG-2324. Se ordena la sentencia if
            if (Password.Length > numerodoce)
            {
                length = true;
            }

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in Password)//! AERG-2324.Cambiamos el nombre por ser poco significtivo 
            {
                if (char.IsLower(c))
                {
                    //! AERG-2324.Se cambia elnombre de la variable por un nombre más significativo 
                    minusculas = true;//! AERG-2324.Debe de haber un espacio entre igualdades
                }
            }
            foreach (char c in Password)
            {
                if (char.IsUpper(c))
                {
                    mayusculas = true;//! AERG-2324.Debe de haber un espacio entre igualdades
                }
            }
            foreach (char c in Password)
            {
                if (char.IsDigit(c))
                {
                    numeros = true;//! AERG-2324.Debe de haber un espacio entre igualdades
                }
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            //! AERG-2324.Se han de separar la igualdad y marcar con llaves
            
            int f = 0;
            if (minusculas)
            {
                f++;
            }
            if (mayusculas)
            {
                f++;
            }
            if (numeros)
            {
                f++;
            }
            if (length)
            {
                f++;
            }

            return f;
        }
    }
}
