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
    public partial class FrmLogin : Form
    {
        Persona usuario;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogueate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbNombre.Text) && string.IsNullOrEmpty(txbPass.Text))
            {
                MessageBox.Show("Debe ingresar datos para poder loguearse","Error!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string nombre = txbNombre.Text;
                string pass = txbPass.Text;
                bool esAdmin= cbEsAdmin.Checked;
                usuario = Bar.CheckearUsuario(nombre, pass, esAdmin);
                if (usuario is not null)
                {
                    FrmMenuPrincipal frmMenu = new FrmMenuPrincipal(usuario);
                    frmMenu.Show();
                    this.Hide();
                }else
                {
                    try
                    {
                        using(SoundPlayer sp = new SoundPlayer(Properties.Resources.sonido))
                        {
                            sp.Play();
                        }
                        MessageBox.Show("El usuario ingresado es incorrecto", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("No se pudo encontrar el archivo de audio!!!");
                    }
                }
            }
        }

        private void btnCompletarEmpleado_Click(object sender, EventArgs e)
        {
            txbNombre.Text = "Matias";
            txbPass.Text = "xd";
            cbEsAdmin.Checked = false;
        }

        private void btnCompletarAdmin_Click(object sender, EventArgs e)
        {
            txbNombre.Text = "Lucas";
            txbPass.Text = "datnetcom";
            cbEsAdmin.Checked = true;
        }

    }
}
