using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Bebida
    {
        public string nombre;
        public float precio;
        public List<Bebida> bebidas();

        public void Bebida(string unNombre, float unPrecio)
        {
            nombre = unNombre;
            precio = unPrecio;

        }
    }
}
