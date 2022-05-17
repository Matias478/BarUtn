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
    public partial class FrmListaEmpleados : Form
    {
        public FrmListaEmpleados()
        {
            InitializeComponent();
        }

        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            rtbListaEmpleados.Text = Bar.MostrarEmpleados();
        }

        private void btnCerrarFrmListaEmpleados_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
