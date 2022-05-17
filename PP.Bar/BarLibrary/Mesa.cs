using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarLibrary
{
    public enum EMetodoDePago
    {
        Efectivo,
        MercadoPago,
        TarjetaDeDebito,
        TarjetaDeCredito,
        Inconcluso
    }
    public class Mesa
    {
        static int ultimoNumeroMesa;
        int numeroMesa;
        float saldo;
        static bool conEstacionamiento;
        static EMetodoDePago metodoDePago;
        //Dictionary<int, int> pedidos;
        List<Producto> producto;

        static Mesa()
        {
            ultimoNumeroMesa = 0;
        }
        public Mesa()
        {
            numeroMesa = ultimoNumeroMesa;
            producto = new List<Producto>();
            //pedidos = new Dictionary<int, int>();
            ultimoNumeroMesa++;
        }
        public Mesa(List<Producto> pedido, bool estacionamiento, EMetodoDePago meteodoDePagos) 
            : this()
        {
            conEstacionamiento = estacionamiento;
            metodoDePago = meteodoDePagos;
            producto = pedido;
            saldo = CalcularCosto(pedido);
        }

        public int NumeroMesa { get { return numeroMesa; } }
        public List<Producto> Producto{ get { return producto; } }
        public static bool ConEstacionamiento { get { return conEstacionamiento; } }
        public static EMetodoDePago MetodoDePago { get { return metodoDePago; } }
        public bool EsBarra { get { return numeroMesa > 15; } }
        public float Saldo { get { return saldo; } }
        public override string ToString()
        {
            string tipoMesa;
            if(EsBarra==true)
            { tipoMesa = "Barra"; }
            else { tipoMesa = "Mesa"; }
                
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero de {tipoMesa}: {NumeroMesa}");
            sb.AppendLine($"Saldo: {Saldo}");

            return sb.ToString();
        }

        /// <summary>
        /// Calcula el costo de la cuenta de la mesa y hace un recargo si uso el estacionamiento
        /// O pago con un metodo distinto a efectivo
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        private float CalcularCosto(List<Producto> pedido)
        {
            float costo=0;
            if(pedido is not null)
            {
                foreach (Producto item in pedido)
                {
                    costo += item.Precio;
                }
                //for (int i = 0; i < pedido.Count; i++)
                //{
                //    costo += pedido[i].Items[i].Precio;
                //}
                if (ConEstacionamiento == true)
                {
                    costo += 100;
                }
                switch (MetodoDePago)
                {
                    case EMetodoDePago.TarjetaDeCredito:
                        costo += 150;
                        break;
                    case EMetodoDePago.MercadoPago:
                        costo += 80;
                        break;
                    case EMetodoDePago.TarjetaDeDebito:
                        costo += 120;
                        break;
                }
            }
            return costo; 
        }



    }
}
