using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
            lblNumeroMesa.Text = $"{tipoMesa} N°" + Bar.Mesas[botonPresionado].NumeroMesa.ToString();
            lblSaldo.Text = "Saldo: " + Bar.Mesas[botonPresionado].CalcularParcial().ToString();
            cmbTipoDePago.DataSource = Enum.GetValues(typeof(EMetodoDePago));
            CargarProductos();

            cmbTipoDePago.SelectedIndex = -1;
            cxbConEstacionamiento.Checked = false;
        }

        /// <summary>
        /// Carga la lista de productos al combobox y si es barra borra los productos de comida
        /// </summary>
        private void CargarProductos()
        {
            if (auxMesa.EsBarra==true)
            {
                foreach (Producto item in Bar.Inventario)
                {
                    cmbProducto.Items.Add(item.Nombre);
                    if(item is Comida)
                    {
                        cmbProducto.Items.Remove(item.Nombre);
                    }
                }
            }
            else
            {
                foreach (Producto item in Bar.Inventario)
                {
                    cmbProducto.Items.Add(item.Nombre);
                }
            }
        }

        private void CargarSonidoDeCampana()
        {
            try
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.ServiceRing);
                sp.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            }else if (txbCantidad.Text == "0" || !int.TryParse(txbCantidad.Text, out int cant))
            {
                MessageBox.Show("Debe ingresar una cantidad!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombre = cmbProducto.Text;
                foreach (Producto item in Bar.Inventario)
                {
                    if(item.Nombre==nombre)
                    {
                        if(item.Cantidad<cant)
                        {
                            MessageBox.Show("La cantidad pedida supera la cantidad del producto en el inventario");
                        }
                        else
                        {
                            CargarSonidoDeCampana();
                            auxMesa.AgregarProductos(item, cant);
                            lblSaldo.Text = "Saldo: "+ auxMesa.CalcularParcial().ToString();
                            auxMesa.Saldo=auxMesa.CalcularParcial();
                            RefrescarInfo();
                            FrmMenuPrincipal.ObtenerEstadoMesas();
                        }
                    }
                }
            }

        }

        private void RefrescarInfo()
        {
            cmbProducto.SelectedIndex= -1;
            txbCantidad.Text = "";
            cmbTipoDePago.SelectedIndex = -1;
            cxbConEstacionamiento.Checked = false;
        }
         
        private void btnCerrarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenuPrincipal.CargarSonidoAmbiente();
        }

        private void btnCerrarCuenta_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmbTipoDePago.Text) || cmbTipoDePago.Text=="Inconcluso")
            {
                MessageBox.Show("Debe ingresar si tiene estacionamiento y su metodo de pago para cerrar la cuenta","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }else if(auxMesa.Producto.Count==0)
              {
                MessageBox.Show("Tiene que cargar al menos un producto para cerrar la cuenta");
              }else
               {
                   auxMesa.ConEstacionamiento = cxbConEstacionamiento.Checked;
                   auxMesa.MetodoDePago = (EMetodoDePago)Enum.Parse(typeof(EMetodoDePago), cmbTipoDePago.Text);

                   MessageBox.Show("Saldo Final: " + auxMesa.CalcularTotal(/*auxMesa.Producto*/).ToString());
                   auxMesa.Saldo = auxMesa.CalcularTotal(/*auxMesa.Producto*/);
                   lblSaldo.Text = "Saldo Final" + auxMesa.Saldo.ToString();
                   auxMesa.Pedidos.Clear();
                   auxMesa.Saldo = 0;
                FrmMenuPrincipal.ObtenerEstadoMesas();
                   this.Close();
               }
        }



    }
}
