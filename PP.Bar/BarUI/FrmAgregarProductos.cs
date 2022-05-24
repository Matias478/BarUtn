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
    public partial class FrmAgregarProductos : Form
    {
        bool btnAgregarBebidaFuePresionado=false;
        bool btnAgregarComidaFuePresionado=false;

        public FrmAgregarProductos()
        {
            InitializeComponent();
        }

        private void FrmAgregarProductos_Load(object sender, EventArgs e)
        {
            CustomizarDiseño();
            cmbCantidadMM.DataSource = Enum.GetValues(typeof(ECantMm));
            cmbIngredientes.DataSource= Enum.GetValues(typeof(EIngredientes));
            LimpiarInfo();
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CerrarElPanel()
        {
            if (btnAgregarBebidaFuePresionado == true)
            {
                panelQueAgreagar.Visible = false;
                
            }else if(btnAgregarComidaFuePresionado==true)
            {
                panelQueAgreagar.Visible = false;
            }
        }
        /// <summary>
        /// Usa los atributos btnAgregarComidaFuePresionado y btnAgregarBebidaFuePresionado para saber si los botones fueron presionados
        /// y de ahi customiza el diseño dependiendo el boton que se selecciono
        /// </summary>
        private void CustomizarDiseño()
        {
            if(btnAgregarComidaFuePresionado != true && btnAgregarBebidaFuePresionado!=true)
            {
                txbNombre.Visible = false;
                lblNombreProducto.Visible = false;
                txbCantidad.Visible = false;
                lblCantidad.Visible = false;
                cmbCantidadMM.Visible = false;
                lblCantidadMM.Visible = false;
                cbxTieneAlcohol.Visible = false;
                cmbIngredientes.Visible = false;
                lblIngredientes.Visible = false;
                btnAgregarProductos.Visible = false;
            }
            else if(btnAgregarComidaFuePresionado==true)
            {
                CerrarElPanel();
                txbNombre.Visible = true;
                lblNombreProducto.Visible = true;
                txbCantidad.Visible = true;
                lblCantidad.Visible = true;
                cmbCantidadMM.Visible = false;
                cbxTieneAlcohol.Visible = false;
                cmbIngredientes.Visible = true;
                lblIngredientes.Visible = true;
                btnAgregarProductos.Visible = true;

            }
            else if(btnAgregarBebidaFuePresionado==true)
            {
                CerrarElPanel();
                txbNombre.Visible = true;
                lblNombreProducto.Visible = true;
                txbCantidad.Visible = true;
                lblCantidad.Visible = true;
                cmbCantidadMM.Visible = true;
                lblCantidadMM.Visible = true;
                cbxTieneAlcohol.Visible = true;
                cmbIngredientes.Visible = false;
                lblIngredientes.Visible = false;
                btnAgregarProductos.Visible = true;
            }
            else if (btnAgregarComidaFuePresionado != true || btnAgregarBebidaFuePresionado != true)
            {
                txbNombre.Visible = false;
                lblNombreProducto.Visible = false;
                txbCantidad.Visible = false;
                lblCantidad.Visible = false;
                cmbCantidadMM.Visible = false;
                lblCantidadMM.Visible = false;
                cbxTieneAlcohol.Visible = false;
                cmbIngredientes.Visible = false;
                lblIngredientes.Visible = false;
                btnAgregarProductos.Visible = false;
            }
        }

        private void LimpiarInfo()
        {
            txbNombre.Text = "";
            txbCantidad.Text = "";
            cmbIngredientes.SelectedIndex = -1;
            cmbCantidadMM.SelectedIndex = -1;
        }

        private void btnAgregarComida_Click(object sender, EventArgs e)
        {
            btnAgregarComidaFuePresionado = true;
            CerrarElPanel();
            CustomizarDiseño();
        }

        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            btnAgregarBebidaFuePresionado = true;
            CerrarElPanel();
            CustomizarDiseño();
        }

        /// <summary>
        /// Verifica si el boton Bebida/Comida fue presionado y crea un nuevo producto en la lista inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            string nombre;
            if (string.IsNullOrEmpty(txbNombre.Text) || int.TryParse(txbNombre.Text,out int name))
            {
                MessageBox.Show("Debe ingresar caracteres");
            }
            else if (!int.TryParse(txbCantidad.Text, out int cant) || cant<0)
            {
                MessageBox.Show("Solo se pueden ingresar numeros mayores al 0!!!");
            }
            else if(btnAgregarComidaFuePresionado==true)
            {
                if (string.IsNullOrEmpty(cmbIngredientes.Text))
                {
                    MessageBox.Show("Se deben especificar los ingredientes");
                }
                else
                {
                    nombre = txbNombre.Text;
                    EIngredientes ingredientes = (EIngredientes)Enum.Parse(typeof(EIngredientes), cmbIngredientes.Text);

                    Bar.Inventario.Add(new Comida(nombre, cant, new List<EIngredientes> { ingredientes }));
                    
                    MessageBox.Show("El producto se agrego correctamente");
                    panelQueAgreagar.Visible = true;
                    btnAgregarComidaFuePresionado = false;
                    CustomizarDiseño();
                    LimpiarInfo();
                }
            }else if(btnAgregarBebidaFuePresionado==true)
            {
                if (string.IsNullOrEmpty(cmbCantidadMM.Text))
                {
                    MessageBox.Show("Se debe especificar la cant en MM");
                }
                else
                {
                    nombre=txbNombre.Text;
                    ECantMm cantidadMM = (ECantMm)Enum.Parse(typeof(ECantMm), cmbCantidadMM.Text);
                    bool conAlcohol = cbxTieneAlcohol.Checked;

                    Bar.Inventario.Add(new Bebidas(nombre, cant, conAlcohol, cantidadMM));

                    MessageBox.Show("El producto se agrego correctamente");
                    panelQueAgreagar.Visible = true;
                    btnAgregarBebidaFuePresionado = false;
                    CustomizarDiseño();
                    LimpiarInfo();
                }
            }

        }


    }
}
