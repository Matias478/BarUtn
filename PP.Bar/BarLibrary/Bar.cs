using System.Collections.Generic;
using System.Text;

namespace BarLibrary
{

    public static class Bar
    {
        static List<Persona> listaUsuarios;
        static List<Mesa> mesas;
        static List<Producto> inventario;

        static Bar()
        {
            CargaEmpleados();
            CargaMesas();
            CargarProductos();
        }

        static public List<Mesa> Mesas { get { return mesas; } }
        static public List<Persona> ListaUsuarios { get { return listaUsuarios; } }
        static public List<Producto> Inventario { get { return inventario; } }

        static private void CargaEmpleados()
        {
            listaUsuarios = new List<Persona>();

            ListaUsuarios.Add(new Persona("Matias","Ferrari",50000, "xd", false));
            ListaUsuarios.Add(new Persona("Fede","Barletta",55500, "asd123", false));
            ListaUsuarios.Add(new Persona("Daniel","Gomez",30040, "gtaIV", false));
            ListaUsuarios.Add(new Persona("Ramos","Puto",70040, "Urulogog", false));
            ListaUsuarios.Add(new Persona("Lucas","Lauriente",120000, "datnetcom", true));
        }

        private static void CargaMesas()
        {
            mesas = new List<Mesa>(20);

            mesas.Add(new Mesa(new List<Producto>()
            {
            new Comida("Pizza",2,new List<EIngredientes>(){EIngredientes.Queso,EIngredientes.Harina,EIngredientes.Cebolla,EIngredientes.Jamon,EIngredientes.SalsaTomate}),
            new Bebidas("Coca-Cola",1,false,ECantMm.BotellaLitroMedio),
            new Bebidas("Cerveza",1,true,ECantMm.BotellaLitro)}, false, EMetodoDePago.TarjetaDeDebito));

            mesas.Add(new Mesa(new List<Producto>()
            {
            new Comida("Hamburguesa con queso",2,new List<EIngredientes>(){EIngredientes.Queso,EIngredientes.Pan,EIngredientes.CarneRoja}),
            new Bebidas("Sprite",1,false,ECantMm.BotellaLitroMedio)}, false, EMetodoDePago.Efectivo));

            mesas.Add(new Mesa(new List<Producto>()
            {
            new Comida("Tostados",1,new List<EIngredientes>(){EIngredientes.Queso,EIngredientes.Pan,EIngredientes.Jamon}),
            new Bebidas("Jugo de naranja",1,false,ECantMm.Vaso500mm)}, true, EMetodoDePago.Efectivo));

            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
            mesas.Add(new Mesa(new List<Producto>(), false, EMetodoDePago.Inconcluso));
        }

        private static void CargarProductos()
        {
            inventario = new List<Producto>
            {
                new Bebidas("Jugo de naranja", 50, false, ECantMm.Vaso500mm),
                new Bebidas("Sprite", 110, false, ECantMm.BotellaLitroMedio),
                new Bebidas("Cerveza", 130, true, ECantMm.BotellaLitro),
                new Bebidas("Coca-Cola", 200, true, ECantMm.BotellaLitro),

                new Comida("Pizza", 40, new List<EIngredientes>() { EIngredientes.Queso, EIngredientes.Harina, EIngredientes.Cebolla, EIngredientes.Jamon, EIngredientes.SalsaTomate }),
                new Comida("Hamburguesa Con queso", 50, new List<EIngredientes>() { EIngredientes.Queso, EIngredientes.Harina, EIngredientes.Cebolla, EIngredientes.Jamon, EIngredientes.SalsaTomate }),
                new Comida("Tostados", 100, new List<EIngredientes>() { EIngredientes.Queso, EIngredientes.Pan, EIngredientes.Jamon })
            };
        }

        static public Persona ChekearUsuario(string nombre, string pass, bool esAdmin)
        {
            foreach (Persona item in listaUsuarios)
            {
                if (item.CheckearUsuario(nombre, pass, esAdmin))
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// Crea una lista dictionary y agrega las mesas cuando estan desocupadas o no tienen ningun pedido
        /// Devuelve el dictionary de mesas 
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, bool> EstadoMesas()
        {
            Dictionary<int, bool> estadoMesas = new Dictionary<int, bool>();

            for(int i=0;i<mesas.Count;i++)
            {
                estadoMesas.Add(i, mesas[i].Producto==null);
            }

            return estadoMesas;
        }

        public static string MostrarMesa(int idMesa)
        {
            Mesa auxMesa = null;
            foreach (Mesa item in mesas)
            {
                if (item.NumeroMesa == idMesa)
                {
                    auxMesa = item;
                    return auxMesa.ToString();
                } 
            }

            if (auxMesa is null)
            {
                return "mesa no encontrada";
            }

            return auxMesa.ToString();
        }

        public static string MostrarEmpleados()
        {
            Persona auxPersona = null;
            StringBuilder sb = new StringBuilder();
            foreach (Persona item in listaUsuarios)
            {
                auxPersona = item;
                sb.AppendLine(auxPersona.ToString());
            }
            if(auxPersona is null)
            {
                return "Empleado no encontrado";
            }

            return sb.ToString();
        }
        public static string MostrarListaMesas()
        {
            Mesa auxMesa = null;
            StringBuilder sb = new StringBuilder();
            foreach (Mesa item in mesas)
            {
                auxMesa = item;
                sb.AppendLine(auxMesa.ToString());
            }
            if (auxMesa is null)
            {
                return "Empleado no encontrado";
            }

            return sb.ToString();
        }

    }
}
