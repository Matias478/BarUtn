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
        List<Producto> producto;
        Dictionary<Producto, int> pedidos;

        static Mesa()
        {
            ultimoNumeroMesa = 1;
        }
        private Mesa()
        {
            numeroMesa = ultimoNumeroMesa;
            producto = new List<Producto>();
            pedidos=new Dictionary<Producto, int>();
            ultimoNumeroMesa++;
        }
        public Mesa(List<Producto> pedido, bool estacionamiento, EMetodoDePago meteodoDePagos) 
            : this()
        {
            conEstacionamiento = estacionamiento;
            metodoDePago = meteodoDePagos;
            producto = pedido;
            Saldo = 0;
        }

        public int NumeroMesa { get { return numeroMesa; } }
        public List<Producto> Producto{ get { return producto; } set { producto = value; } }
        public Dictionary<Producto,int> Pedidos { get { return pedidos; }  set { pedidos = CargarProductosEnPedidos(); } }
        public bool ConEstacionamiento { get { return conEstacionamiento; } set { conEstacionamiento = value; } }
        public EMetodoDePago MetodoDePago { get { return metodoDePago; } set { metodoDePago = value; } }
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
            sb.AppendLine($"Saldo: {Saldo=CalcularTotal()}");
            sb.AppendLine($"Productos Pedidos: ");
            foreach(KeyValuePair<Producto,int> item in pedidos)
            {
                sb.AppendLine($"{item.Key.Nombre}  {item.Value} unidad/es");
            }
            if(conEstacionamiento==true)
            {
                sb.AppendLine($"Con estacionamiento");
            }else { sb.AppendLine("Sin estacionamiento"); }
            sb.AppendLine($"Metodo de pago: {MetodoDePago}");

            return sb.ToString();
        }
        private Dictionary<Producto,int> CargarProductosEnPedidos()
        {
            foreach (Producto item in Producto)
            {
                pedidos.Add(item, item.Cantidad);
                return pedidos;
            }
            return null;    
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
                pedidos.Add(productoRecibido, cant);
            }
        }

        /// <summary>
        /// Instancia la lista de productos de una mesa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void InstanciarLista(int id)
        {
            if (NumeroMesa == id)
            {
                Producto = new List<Producto>();
            }
        }

        /// <summary>
        /// Calcula el costo de los productos, sin agregarle los recargos
        /// </summary>
        /// <returns></returns>
        public float CalcularParcial()
        {
            float costo = 0;
            foreach (KeyValuePair<Producto, int> item in pedidos)
            {
                costo += item.Key.Precio * item.Value;
            }
            return costo;
        }
     
        /// <summary>
        /// Calcula el costo de la cuenta de la mesa y hace un recargo si uso el estacionamiento
        /// O pago con un metodo distinto a efectivo
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public float CalcularTotal(/*List<Producto> pedido*/)
        {
            float costo = CalcularParcial();    

            if(costo>0)
            {
                   if (ConEstacionamiento == true)
                    {
                        costo += 100;
                    } 
                    if(MetodoDePago==EMetodoDePago.TarjetaDeCredito)
                    {
                        costo += (costo*10/100);
                    }
            }
            
            return costo; 
        }

        

    }
}
