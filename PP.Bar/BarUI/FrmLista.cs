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
        bool tipoLista;
        public FrmLista()
        {
            InitializeComponent();
        }
        public FrmLista(bool tipoLista):this()
        {
            this.tipoLista = tipoLista;
        }

        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            if(tipoLista==true)
            {
                rtbLista.Text = Bar.MostrarEmpleados();
            }else { rtbLista.Text = Bar.MostrarListaMesas(); }
        }

        private void btnCerrarFrmListaEmpleados_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
