using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Bebida
    {
        public string nombre;
        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public void Bebida(string unNombre, float unPrecio)
        {
            nombre = unNombre;
            precio = unPrecio;

        }
    }
}
