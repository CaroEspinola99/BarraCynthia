﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Barra
    {
        public int bebida;
        private int cantidad;
        public int capacidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public List<Cliente> clientes();
        public float precio;

        public void Barra(int unaBebida, int unaCantidad, float unPrecio)
        {
            bebida = unaBebida;
            cantidad = unaCantidad;
            precio = unPrecio;
            capacidad = 2;
        }
        public int DescontarStock(int cantidad)
        {

        }
    }
}
