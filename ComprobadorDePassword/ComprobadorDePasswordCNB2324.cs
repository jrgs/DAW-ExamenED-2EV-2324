namespace ComprobadorDePassword
{
    public class comprobadorDePasswordCNB2324
    {
        public string password;
        private bool minusculas;
        private bool mayusculas;
        private bool numeros;
        private bool longitud;

        public comprobadorDePasswordCNB2324()
        {
            minusculas = mayusculas = numeros = longitud = false;
        }

        public int Test(string palabra)
        {
            bool Minusculas = false;
            bool Mayusculas = false;
            bool Numeros = false;
            bool Longitud = false;
           
            string password = palabra;

            if (password==null || password.Length <= 0)
            {
               return -1; // Si la contraseña es nula o vacía, devolvemos un código de error
            }
               
            if (password.Length < 6)
            {
                return 0; // No tiene la longitud mínima, error
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
          
            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int fortaleza= 0;
            if (Minusculas) fortaleza++;
            if (Mayusculas) fortaleza++;
            if (Numeros) fortaleza++;
            if (Longitud) fortaleza++;

            return fortaleza;
        }
    }
}
