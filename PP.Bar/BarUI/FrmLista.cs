using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarLibrary;

namespace BarUI
{
    public partial class FrmLista : Form
    {
        string tipoLista;
        public FrmLista()
        {
            InitializeComponent();
        }
        public FrmLista(string lista):this()
        {
            this.tipoLista = lista;
        }

        /// <summary>
        /// Segun que reciba por parametros muestra la lista de lo que recibio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            switch (tipoLista)
            {
                case "ListaEmpleados":
                    rtbLista.Text = Bar.MostrarEmpleados();
                    btnRellenarStock.Visible = false;
                    break;
                case "ListaMesas":
                   rtbLista.Text = Bar.MostrarListaMesas();
                    btnRellenarStock.Visible = false;
                    break;
                case "ListaInventario":
                    rtbLista.Text = Bar.MostrarInventario();
                    CuandoQuedaPocoStock();
                    btnRellenarStock.Visible = true;
                    break;
            }
        }
        
        /// <summary>
        /// Avisa por un messageBox que queda poco stock de un producto
        /// </summary>
        private void CuandoQuedaPocoStock()
        {
            foreach (Producto item in Bar.Inventario)
            {
                if (item.Cantidad<20 && item.Cantidad>0)
                {
                    MessageBox.Show($"QUEDA POCO STOCK DE {item.Nombre}!!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }else if (item.Cantidad==0)
                {
                    MessageBox.Show($"NO HAY STOCK DE {item.Nombre}!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void RellenarStock()
        {
            foreach (Producto item in Bar.Inventario)
            {
                if (item.Cantidad < 20)
                {
                    item.Cantidad += 30;
                }
            }
        }

        private void btnCerrarFrmListaEmpleados_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Al producto que tenga menos de 20 unidades, se le rellenaran mas al apretar este boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRellenarStock_Click(object sender, EventArgs e)
        {
            RellenarStock();
            rtbLista.Text = Bar.MostrarInventario();
        }
    }
}
