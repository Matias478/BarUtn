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

        public bool ContieneALohol { get { return contieneALohol; } set { contieneALohol=value; } }
        public ECantMm CantidadMm { get { return cantidadMm; } set { cantidadMm=value; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{cantidad} unidades de {cantidadMm} de {Nombre}");
            if(contieneALohol==false)
            {
                sb.Append($" No contiene alcohol");
            }else { sb.Append($" Contiene alcohol"); }

            return sb.ToString();
        }

    }
}
