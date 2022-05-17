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
        bool conEstacionamiento;
        EMetodoDePago metodoDePago;
        //Dictionary<int, int> pedidos;
        List<Producto> producto;

        static Mesa()
        {
            ultimoNumeroMesa = 1;
        }
        private Mesa()
        {
            numeroMesa = ultimoNumeroMesa;
            producto = new List<Producto>();
            //pedidos = new Dictionary<int, int>();
            ultimoNumeroMesa++;
        }
        public Mesa(List<Producto> pedido, bool estacionamiento, EMetodoDePago meteodoDePagos) 
            : this()
        {
            //producto = new List<Producto>();
            conEstacionamiento = estacionamiento;
            metodoDePago = meteodoDePagos;
            producto = pedido;
            Saldo = CalcularTotal(pedido);
        }

        public int NumeroMesa { get { return numeroMesa; } }
        public List<Producto> Producto{ get { return producto; } }
        public bool ConEstacionamiento { get { return conEstacionamiento; } }
        public EMetodoDePago MetodoDePago { get { return metodoDePago; } }
        public bool EsBarra { get { return numeroMesa > 15; } }
        public float Saldo { get { return saldo; } set { saldo = value; } }
        public override string ToString()
        {
            string tipoMesa;
            if(EsBarra==true)
            { tipoMesa = "Barra"; }
            else { tipoMesa = "Mesa"; }
                
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero de {tipoMesa}: {NumeroMesa}");
            sb.AppendLine($"Saldo: {Saldo}");
            if(conEstacionamiento==true)
            {
                sb.AppendLine($"Con estacionamiento");
            }else { sb.AppendLine("Sin estacionamiento"); }
            sb.AppendLine($"Metodo de pago: {MetodoDePago}");

            return sb.ToString();
        }

        /// <summary>
        /// Agrega el producto recibido a la lista de la mesa y reduce la cantidad del mismo 
        /// </summary>
        /// <param name="productoRecibido"></param>
        /// <param name="cant"></param>
        public void AgregarProductos(Producto productoRecibido,int cant)
        {
            if(productoRecibido is not null)
            {
                producto.Add(productoRecibido);
                productoRecibido.Cantidad -= cant;
            }
        }
        public float CalcularParcial()
        {
            float costo = 0;
            foreach (Producto item in producto)
            {
                costo += item.Precio;
            }
            return costo;
        }
        

        /// <summary>
        /// Calcula el costo de la cuenta de la mesa y hace un recargo si uso el estacionamiento
        /// O pago con un metodo distinto a efectivo
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        private float CalcularTotal(List<Producto> pedido)
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
