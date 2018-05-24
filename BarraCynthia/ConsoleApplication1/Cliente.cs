using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Cliente
    {
        public int cantidad;
        public float dinero;
        public List<Bebida> bebidas();
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
            if (dinero > )
            {
                
            }
        }

        public int DescontarBebida(int cantidad, Bebida bebidas)
        { 
            
        }

        public int DescontarDinero(float dinero)
        { 
        
        }
    }
}
