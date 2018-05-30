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
        public List<Bebida> bebidas;
        public string nombre;
        public DateTime tiempo;

        public void Cliente(int unaCantidad, float unDinero, string unNombre, DateTime unTiempo)
        {
            cantidad = unaCantidad;
            dinero = unDinero;
            nombre = unNombre;
            tiempo = unTiempo;
            bebidas = new List<Bebida>();
        }
        public void DejarBarra(Bebida unaBebida)
        {
            while(true)
            {
                if (unaBebida.Precio > dinero)
                {
                    break;
                }
            }
        }

        public void DescontarBebida(Bebida unaBebida)
        {
            cantidad = unaBebida.Precio - unaBebida;
            //Llamar al metodo descontarDinero1
            //Eliminar bebida de la lista bebidas 
        }

        public void DescontarDinero(Bebida unaBebida)
        {
             dinero = dinero - unaBebida.Precio;
             
        }
    }
}
