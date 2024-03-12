using System;

namespace ComprobadorDePassword
{
    
    


    public class ComprobadorDePasswordCNB2324
    {
        public const string ERROR_CONTRASENYA_NULA = "Contraseña nula";
        public const string ERROR_CONTRASENYA_INVALIDA = "No tiene la longitud mínima";


        private string password;
        private bool minusculas;
        private bool mayusculas;
        private bool numeros;
        private bool longitud;
        /// <summary>
        /// Constructor que nos indica que todos los valores están a false
        /// </summary>
        public ComprobadorDePasswordCNB2324()
        { 
            this.Minusculas = false;
            this.Mayusculas = false;
            this.Numeros = false;
            this.Longitud = false;
         
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Minusculas 
        { 
            get { return minusculas; }
            set { minusculas = value; }
        }

        public bool Mayusculas {
           get { return mayusculas; }
           set { mayusculas = value; }
        }

        public bool Numeros { 
            get { return numeros; } 
            set {  numeros = value; }
        }

        public bool Longitud { 
            get { return longitud; } 
            set {  longitud = value; }
        }
        /// <summary>
        /// Método que se utiliza para comprobar la fortaleza de una contraseña.
        ///<remark>Fortaleza de una contraseña a través de la introducción de caracteres, letras y números</remark>
        /// </summary>
        /// <param name="palabra">El parámetro de recibe es de tipo string y pueden ser letras, números y/o caracteres</param>
        /// <returns> Dependiendo de los valores introducidos nos puede devolver.
        /// <list type="bullet">
        ///     <item>una excepción con un mensaje que la contraseña es nula si no se introduce ningún valor</item>
        ///     <item>una excepción con un mensaje que la contrañesa no tiene el límite de caracteres necesarios si lo introducido es menor de 6 caracteres.</item>
        ///     </list></returns>
        /// <exception cref="ArgumentOutOfRangeException"> Dos tipos de excepciones. 
        /// <para>si el valor introducido es menor de 6 caracteres de longitud, la contraseña lanzará un error de "ERROR CONTRASENYA INVALIDA" con el siguiente mensaje "No tiene la longitud mínima"</para> 
        /// <para> si el usuario no introduce ningún número, caracter o letra, se devolverá un error de "ERROR CONTRASENYA NULA" con el siguiente mensaje "Contraseña nula"</para>
        /// </exception>
        /// <return>Este método, si se efectúa correctamente nos devolverá el string "Fortaleza"</return>
        public int Test(string palabra)
        {
            bool Minusculas = false;
            bool Mayusculas = false;
            bool Numeros = false;
            bool Longitud = false;
           
            string password = palabra;

            if (password==null || password.Length <= 0)
            {
                throw new ArgumentOutOfRangeException (ERROR_CONTRASENYA_NULA); // Si la contraseña es nula o vacía, devolvemos un código de error
            }
               
            if (password.Length < 6)
            {
                throw new ArgumentOutOfRangeException (ERROR_CONTRASENYA_INVALIDA); // No tiene la longitud mínima, error
            }
                
            if (password.Length > 12) Longitud = true;
            {
                // Recorremos la cadena buscando minúsculas, mayúsculas y números
                //
                foreach (char c in password)
                {
                    if (char.IsLower(c))
                    {
                        Minusculas = true;
                    }
                }
                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        Mayusculas = true;
                    }
                }
                foreach (char c in password)
                {
                    if (char.IsDigit(c))
                    {
                        Numeros = true;
                    }
                }

            }
            // Calculamos el nivel de Fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int Fortaleza= 0;
            if (Minusculas) Fortaleza++;
            if (Mayusculas) Fortaleza++;
            if (Numeros) Fortaleza++;
            if (Longitud) Fortaleza++;

            return Fortaleza;
        }
    }
}
