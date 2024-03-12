namespace ComprobadorDePassword2324
{
    /// <summary>
    /// La clase que compruebe el nivel de la fuerza de la contraseña.
    /// </summary>
    /// <valor>
    /// Devuelve un valor, que corresponde al nivel de la fuerza de la contraseña:
    ///     <list type="table">
    ///         <item>
    ///             <description>-1 - contraseña vacía</description>
    ///         </item>
    ///         <item>
    ///             <description>0 - contraseña no cumple los requisitos mínimos de seguridad</description>
    ///         </item>
    ///         <item>
    ///             <description>1 - contraseña débil</description>
    ///         </item>
    ///         <item>
    ///             <description>3 - contraseña normal</description>
    ///         </item>
    ///         <item>
    ///             <description>3 - contraseña fuerte</description>
    ///         </item>
    ///         <item>
    ///             <description>4 - contraseña muy fuerte</description>
    ///         </item>
    ///     </list>
    /// </valor>
    public class ComprobadorDePasswordSO2324
    {
        /// <summary>
        /// Propiedad de la clase, que muestra, si la contraseña tiene minúsculas.
        /// </summary>
        private bool minusculas;
        /// <summary>
        /// Propiedad de la clase, que muestra, si la contraseña tiene mayúsculas.
        /// </summary>
        private bool mayusculas;
        /// <summary>
        /// Propiedad de la clase, que muestra, si la contraseña tiene símbolos numéricos.
        /// </summary>
        private bool numeros;
        /// <summary>
        /// Propiedad de la clase, que tiene el valor de la longitud de la contraseña.
        /// </summary>
        private bool longitud;
        /// <summary>
        /// Función constructora de la clase
        /// </summary>
        public bool Minusculas { get => minusculas; set => minusculas=value; }
        public bool Mayusculas { get => mayusculas; set => mayusculas=value; }
        public bool Numeros { get => numeros; set => numeros=value; }
        public bool Longitud { get => longitud; set => longitud=value; }
        public ComprobadorDePasswordSO2324(bool minusculas)
        {
            minusculas = false;
            mayusculas = false;
            numeros = false;
            longitud = false;
            this.minusculas=minusculas;
        }
        /// <summary>
        /// El método de la clase, compruebe la fuerza de la contraseña dada
        /// </summary>
        /// <param name="contrasenya"></param>
        /// <returns>Devuelve un valor, que corresponde al nivel de la fuerza de la contraseña</returns>
        public int test(string contrasenya)
        {
            if (contrasenya == null || contrasenya.Length <= 0)
            {
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error
            }
            if (contrasenya.Length < 6)
            {
                return 0; // No tiene la longitud mínima, error
            }
                

/*
            bool mins = false;
            bool mays = false;
            bool nums = false;
            bool length = false;
*/
            if (contrasenya.Length > 12)
            {
                longitud = true;
            }

            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in contrasenya)
            {
                if (char.IsLower(c))
                {
                    minusculas = true;
                }
            }
            foreach (char c in contrasenya)
            {
                if (char.IsUpper(c))
                {
                    mayusculas = true;
                }
            }
            foreach (char c in contrasenya)
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
            int fuerzaDeContrasenya = 0;
            if (minusculas)
            {
                fuerzaDeContrasenya++;
            } 
            if (mayusculas)
            {
                fuerzaDeContrasenya++;
            }
            if (numeros)
            {
                fuerzaDeContrasenya++;
            }
            if (longitud)
            {
                fuerzaDeContrasenya++;
            }
            return fuerzaDeContrasenya;
        }
    }
}
