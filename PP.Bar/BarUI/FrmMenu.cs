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
        public FrmMenu()
        {
            InitializeComponent();
        }
        public FrmMenu(int botonPresionado):this()
        {
            this.botonPresionado = botonPresionado;
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            string tipoMesa;
            if (Bar.Mesas[botonPresionado].EsBarra == true)
            { tipoMesa = "Barra"; }
            else { tipoMesa = "Mesa"; }
            lblNumeroMesa.Text = $"{tipoMesa} N°" + Bar.Mesas[botonPresionado].NumeroMesa.ToString();//$"Numero de mesa " + botonPresionado.ToString();
            lblSaldo.Text = "Saldo: " + Bar.Mesas[botonPresionado].Saldo.ToString();
            //cmbTipoDePago.DataSource = Enum.GetValues(typeof(EMetodoDePago));
            CargarProductos();
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

            //Bar.Inventario[0].Cantidad = int.Parse(dupCantidad.Text);
            //Bar.Inventario[1].Cantidad = int.Parse(dupCantidad.Text);
            //Bar.Inventario[2].Cantidad = int.Parse(dupCantidad.Text);
            //Bar.Inventario[3].Cantidad = int.Parse(dupCantidad.Text);
            //Bar.Inventario[4].Cantidad = int.Parse(dupCantidad.Text);
            //Bar.Inventario[5].Cantidad = int.Parse(dupCantidad.Text);
            //Bar.Inventario[6].Cantidad = int.Parse(dupCantidad.Text);

        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {



        }

    }
}
