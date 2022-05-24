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

        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            switch (tipoLista)
            {
                case "ListaEmpleados":
                    rtbLista.Text = Bar.MostrarEmpleados();
                break;
                case "ListaMesas":
                   rtbLista.Text = Bar.MostrarListaMesas();
                    break;
                case "ListaInventario":
                    rtbLista.Text = Bar.MostrarInventario();
                    CuandoQuedaPocoStock();
                    break;
            }
        }
        
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

        private void btnCerrarFrmListaEmpleados_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
