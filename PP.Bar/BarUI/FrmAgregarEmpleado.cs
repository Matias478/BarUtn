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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            float sueldo = 0;
            if(string.IsNullOrEmpty(txbNombre.Text) && string.IsNullOrEmpty(txbApellido.Text))
            {
                MessageBox.Show("Solo se pueden ingresar caracteres !!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else if(float.TryParse(txbSueldo.Text, out sueldo))
            {
                MessageBox.Show("Solo se pueden ingresar numeros !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    }
                }
        }



    }
}
