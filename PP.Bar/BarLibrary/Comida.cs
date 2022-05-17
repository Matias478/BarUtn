using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarLibrary
{
    public enum EIngredientes
    {
        CarneRoja,
        Pollo,
        Cebolla,
        Tomate,
        Sal,
        Huevos,
        Harina,
        Pan,
        Queso,
        Aderesos,
        SalsaTomate,
        Jamon
    }
    public class Comida : Producto
    {
        List<EIngredientes> eIngredientes;
        public Comida(string nombre, int cant,List<EIngredientes> eIngredientes)
            : base(nombre, cant)
        {
            this.eIngredientes = eIngredientes;
        }

    }
}
