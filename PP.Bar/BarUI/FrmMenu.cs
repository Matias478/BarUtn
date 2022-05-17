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
    public partial class FrmMenu : Form
    {
        int botonPresionado;
        Mesa auxMesa;
        public FrmMenu()
        {
            InitializeComponent();
        }
        public FrmMenu(int botonPresionado):this()
        {
            this.botonPresionado = botonPresionado;
            auxMesa = Bar.Mesas[botonPresionado];
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            string tipoMesa;
            if (Bar.Mesas[botonPresionado].EsBarra == true)
            { tipoMesa = "Barra"; }
            else { tipoMesa = "Mesa"; }
            lblNumeroMesa.Text = $"{tipoMesa} N°" + Bar.Mesas[botonPresionado].NumeroMesa.ToString();//$"Numero de mesa " + botonPresionado.ToString();
            lblSaldo.Text = "Saldo: " + Bar.Mesas[botonPresionado].CalcularParcial().ToString();
            cmbTipoDePago.DataSource = Enum.GetValues(typeof(EMetodoDePago));
            CargarProductos();

            cxbConEstacionamiento.Visible = false;
            cmbTipoDePago.Visible = false;
            lblMetodoDePago.Visible = false;
        }

        private void CargarProductos()
        {
            cmbProducto.Items.Add(Bar.Inventario[0].Nombre);
            cmbProducto.Items.Add(Bar.Inventario[1].Nombre);
            cmbProducto.Items.Add(Bar.Inventario[2].Nombre);
            cmbProducto.Items.Add(Bar.Inventario[3].Nombre);
            cmbProducto.Items.Add(Bar.Inventario[4].Nombre);
            cmbProducto.Items.Add(Bar.Inventario[5].Nombre);
            cmbProducto.Items.Add(Bar.Inventario[6].Nombre);
        }

        /// <summary>
        ///  Busca productos en el inventario, si coinciden el nombre elegido con el nombre del producto en la lista
        ///  se llama al metodo agregar productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmbProducto.Text))
            {
                MessageBox.Show("Debe elegir un producto!!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }else
            {
                string nombre = cmbProducto.Text;
                int cant = dupCantidad.SelectedIndex;
                foreach (Producto item in Bar.Inventario)
                {
                    if(item.Nombre==nombre)
                    {
                        auxMesa.AgregarProductos(item, cant);
                        lblSaldo.Text = "Saldo: "+ auxMesa.CalcularParcial().ToString();
                        RefrescarInfo();
                    }
                }
            }

        }

        private void RefrescarInfo()
        {
            cmbProducto.SelectedIndex=-1;
            dupCantidad.SelectedIndex = 0;
            cmbTipoDePago.SelectedIndex = -1;
            cxbConEstacionamiento.Checked = false;
        }
         
        private void btnCerrarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarCuenta_Click(object sender, EventArgs e)
        {
            

        }

    }
}
