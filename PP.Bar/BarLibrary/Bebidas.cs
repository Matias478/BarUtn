using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarLibrary
{
    public enum ECantMm
    {
        BotellaLitroMedio=1500,
        BotellaLitro=1000,
        LataMediana=330,
        Botella600mm=600,
        Vaso500mm=500,
    }
    public class Bebidas : Producto
    {
        bool contieneALohol;
        ECantMm cantidadMm;

        public Bebidas(string nombre, int cant,bool conAlcohol, ECantMm cantidadMm) 
            :base(nombre, cant)
        {
            this.contieneALohol=conAlcohol;
            this.cantidadMm=cantidadMm;
        }


    }
}
