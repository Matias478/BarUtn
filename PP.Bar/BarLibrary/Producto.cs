using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarLibrary
{
    public abstract class Producto
    {
        protected string nombre;
        protected int cantidad;
        private float precio;

        protected Producto(string nombre, int cant, float precio)
        {
            this.nombre = nombre;
            this.cantidad = cant;
            this.precio = precio;
        }

        public float Precio { get { return precio; } }
        public string Nombre { get { return nombre; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }

    }
}
