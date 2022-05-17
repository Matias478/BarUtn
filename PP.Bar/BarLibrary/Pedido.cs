using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarLibrary
{
    public class Pedido
    {
        int cantidad;
        List<Producto> item;

        public Pedido(int cant, List<Producto> producto)
        {
            cantidad = cant;
            item = producto;
        }

        public List<Producto> Items { get { return item; } }

    }
}
