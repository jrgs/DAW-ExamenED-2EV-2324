using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobadorDePassword
{
    using System;
    using System.Text.RegularExpressions;
    /// <summary>
    /// <para>Creamos la clase comprobadorDePassWord donde se pasa una contraseña</para>
    /// <para>y comprobamos la fortaleza de la misma</para>
    /// </summary>
    public class comprobadorDePassword
    {
        /// <summary>
        /// propiedadad de tipo string con la contraseña del usuario
        /// </summary>
        private string contraseña;
        /// <summary>
        /// propiedad de tipo bool para comprobar si contiene minusculas  la contraseña
        /// </summary>
        private bool mins;
        /// <summary>
        /// propiedad de tipo bool comprobar si contiene mayusculas  la contraseña
        /// </summary>
        private bool mays;
        /// <summary>
        /// propiedad de tipo bool con el numero de numeros que contiene de la contraseña
        /// </summary>
        private bool nums;
        /// <summary>
        /// propiedad de tipo bool con el numero de minusculas de la contraseña
        /// </summary>
        private bool length;

        public string Contraseña { get => contraseña; set => contraseña = value; }
        public bool Mins { get => mins; set => mins = value; }
        public bool Mays { get => mays; set => mays = value; }
        public bool Nums { get => nums; set => nums = value; }
        public bool Length { get => length; set => length = value; }

        public comprobadorDePassword()
        {
            Mins = Mays = Nums = Length = false;
        }



        public int ProbarContraseña(string p)
        {
            Contraseña = p;
            bool mins = false;
            bool mays = false;
            bool nums = false;
            bool length = false;

            if (Contraseña == null || Contraseña.Length <= 0)
            {
                return -1; // Si la contraseña es nula o vacía, devolvemos un código de error
            }


            if (Contraseña.Length < 6)
            {
                return 0; // No tiene la longitud mínima, error
            }





            if (Contraseña.Length >= 6)
            {
                length = true;
            }

            return ComprobarFortaleza(ref mins, ref mays, ref nums, length);
        }

        private int ComprobarFortaleza(ref bool mins, ref bool mays, ref bool nums, bool length)
        {
            // Recorremos la cadena buscando minúsculas, mayúsculas y números
            //
            foreach (char c in Contraseña)
            {
                if (char.IsLower(c))
                {
                    mins = true;
                }
            }
            foreach (char c in Contraseña)
            {
                if (char.IsUpper(c))
                {
                    mays = true;
                }
            }
            foreach (char c in Contraseña)
            {
                if (char.IsDigit(c))
                {
                    nums = true;
                }
            }

            // Calculamos el nivel de fortaleza
            // 4: muy fuerte
            // 3: fuerte
            // 2: normal
            // 1: débil
            int f = 0;
            if (mins)
            {
                f++;
            }
            if (mays)
            {
                f++;
            }
            if (nums)
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
