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
        static Random rnd;

        static Producto()
        {
            rnd = new Random();
        }
        public Producto(string nombre, int cant)
        {
            this.nombre = nombre;
            this.cantidad = cant;
            this.precio = (float)rnd.Next(200,2000);
        }

        public float Precio { get { return precio; } }
        public string Nombre { get { return nombre; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }

    }
}
