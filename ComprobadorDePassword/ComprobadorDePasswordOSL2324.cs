namespace ComprobadorDePassword
{
    public class comprobadorDePassword
    {
        private string mPassword;
        private bool mMinuscula;
        private bool mMayuscula;
        private bool mNumero;
        private bool mLongitud;
        public string password 
            { get => password; 
              set => password = value; }
        public bool minuscula 
            { get => mMinuscula;
              set => mMinuscula = value; }
        public bool mayuscula 
            { get => mMayuscula; 
              set => mMayuscula = value; }
        public bool numero 
            { get => mNumero;
              set => mNumero = value; }
        public bool longitud 
            { get => mLongitud;
              set => mLongitud = value; }

        public comprobadorDePassword()
        {
            minuscula = false;
            mayuscula = false;
            numero = false;
            longitud = false;
        }

        

        public int test(string contrasenya)
        {
            password = contrasenya;

            if (password==null || password.Length<=0)
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error

            if (password.Length < 6)
                return 0; // No tiene la longitud mínima, error


            bool minuscula = false;
            bool mayuscula = false;
            bool numero = false;
            bool longitud = false;

            if (password.Length > 12) 
                longitud = true;

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    minuscula=true;
                }
            }
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    mayuscula=true;
                }
            }
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    numero=true;
                }
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            
            int f=0;
            if (minuscula) 
                f++;
            if (mayuscula) 
                f++;
            if (numero) 
                f++;
            if (longitud) 
                f++;

            return f;
        }
    }
}
