using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Cliente
    {
        public int cantidad;
        public float dinero;
        public List<Bebida> bebidad();
        public List<Cliente> clientes();
        public string nombre;
        public DateTime tiempo;

        public void Cliente(int unaCantidad, float unDinero, string unNombre, DateTime unTiempo)
        {
            cantidad = unaCantidad;
            dinero = unDinero;
            nombre = unNombre;
            tiempo = unTiempo;
        }
        public void DejarBarra()
        {

        }

        public int DescontarBebida()
        { }

        public int DescontarDinero()
        { }
    }
}
