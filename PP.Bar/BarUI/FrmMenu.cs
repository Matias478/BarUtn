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
            string nombre = cmbProducto.Text;
            int cant = dupCantidad.SelectedIndex;
            foreach (Producto item in Bar.Inventario)
            {
                if(item.Nombre==nombre)
                {
                    auxMesa.AgregarProductos(item, cant);
                    lblSaldo.Text = "Saldo: "+ auxMesa.CalcularParcial().ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
