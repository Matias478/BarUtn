using BarLibrary;
using System;
using System.Media;
using System.Windows.Forms;

namespace BarUI
{
    public partial class FrmAgregarEmpleado : Form
    {
        Persona empleadoCreado;
        public FrmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btnCerrarAgregarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenuPrincipal.CargarSonidoAmbiente();
        }

        private void CargarSonidoDeError()
        {
            try
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.WrongAnswer);
                sp.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CargarSonidoDeExito()
        {
            try
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.correct_6033);
                sp.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            float sueldo = 0;
            if(string.IsNullOrEmpty(txbNombre.Text) || string.IsNullOrEmpty(txbApellido.Text) || string.IsNullOrEmpty(txbPassWord.Text))
            {
                CargarSonidoDeError();
                MessageBox.Show("Se deben ingresar todos los datos para crear un empleado !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (float.TryParse(txbNombre.Text,out float name))
            {
                CargarSonidoDeError();
                MessageBox.Show("Solo se pueden ingresar caracteres !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (float.TryParse(txbApellido.Text, out float lastName))
            {
                CargarSonidoDeError();
                MessageBox.Show("Solo se pueden ingresar caracteres !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (!float.TryParse(txbSueldo.Text, out sueldo))
            {
               CargarSonidoDeError(); 
                MessageBox.Show("Solo se pueden ingresar numeros !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (sueldo < 0)
            {
                CargarSonidoDeError();
                MessageBox.Show("No se pueden ingresar numeros negativos!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                string nombre = txbNombre.Text;
                string apellido = txbApellido.Text;

                string passWord = txbPassWord.Text;
                bool esAdmin = cxbEsAdmin.Checked;

                empleadoCreado = new Persona(nombre, apellido, sueldo, passWord, esAdmin);

                if (empleadoCreado is not null)
                {
                    Bar.ListaUsuarios.Add(empleadoCreado);
                    if (esAdmin == false)
                    {
                        CargarSonidoDeExito();
                        MessageBox.Show("Empleado Creado exitosamente");
                        RefrescarTextBox();
                    }
                    else { MessageBox.Show("Administrador Creado exitosamente"); RefrescarTextBox();  }
                }
            }
        }

        private void FrmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            txbNombre.PlaceholderText = "Ingrese nombre";
            txbApellido.PlaceholderText= "Ingrese apellido";
            txbPassWord.PlaceholderText = "Ingrese contraseña";
            txbSueldo.PlaceholderText = "Ingrese sueldo";
            cxbEsAdmin.Checked = false;
        }

        private void RefrescarTextBox()
        {
            txbNombre.Text = "";
            txbApellido.Text = "";
            txbSueldo.Text = "";
            txbPassWord.Text = "";
            cxbEsAdmin.Checked = false;
        }

    }
}
