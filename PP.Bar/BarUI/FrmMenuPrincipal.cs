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
    public partial class FrmMenuPrincipal : Form
    {
        Persona usuarioLogueado;
        Dictionary<int, Button> botones;
        Dictionary<int, bool> disponibilidadMesas;
        private Form formActivo = null;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            CargarMesas();
            CustomizarDiseño();
        }
        public FrmMenuPrincipal(Persona usuario) : this()
        {
            usuarioLogueado = usuario;
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            ObtenerEstadoMesas();
            lblWelcome.Text += usuarioLogueado.Nombre;
            EsAdmin(usuarioLogueado);
        }

        private void EsAdmin(Persona usuario)
        {
            if(usuario.EsAdmin==false)
            {
                btnListaEmpleados.Visible=false;
            }
        }

        private void CargarMesas()
        {
            botones = new Dictionary<int, Button>();

            botones.Add(1, btnMesa1);
            botones.Add(2, btnMesa2);
            botones.Add(3, btnMesa3);
            botones.Add(4, btnMesa4);
            botones.Add(5, btnMesa5);
            botones.Add(6, btnMesa6);
            botones.Add(7, btnMesa7);
            botones.Add(8, btnMesa8);
            botones.Add(9, btnMesa9);
            botones.Add(10, btnMesa10);
            botones.Add(11, btnMesa11);
            botones.Add(12, btnMesa12);
            botones.Add(13, btnMesa13);
            botones.Add(14, btnMesa14);
            botones.Add(15, btnMesa15);
            botones.Add(16, btnBarra16);
            botones.Add(17, btnBarra17);
            botones.Add(18, btnBarra18);
            botones.Add(19, btnBarra19);
            botones.Add(20, btnBarra20);
        }

        /// <summary>
        /// Usa el metodo EstadoMesas que devuelve una lista de mesas con ningun producto
        /// Las recorre y segun su value pinta el boton en verde si estan libres y rojas sino
        /// </summary>
        private void ObtenerEstadoMesas()
        {
            disponibilidadMesas = Bar.EstadoMesas();

            foreach (KeyValuePair<int, bool> mesa in disponibilidadMesas)
            {
                if (mesa.Value)
                {
                    botones[mesa.Key].BackColor = Color.LightGreen;
                }
                else { botones[mesa.Key].BackColor = Color.IndianRed; }
            }
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere Salir?", " Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                e.Cancel = true;
        }

        private void btn_mesas_Click(object sender, EventArgs e)
        {
            Button auxBtn = (Button)sender;

            foreach (KeyValuePair<int, Button> item in botones)
            {
                if (item.Value == auxBtn)
                {
                    MessageBox.Show(Bar.MostrarMesa(item.Key));
                    //abrirFormPequeño(new FrmMenu());
                }
            }
        }

        private void btnListaEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormPequeño(new FrmListaEmpleados());
            //EsconderSubMenu();
        }

        /// <summary>
        /// Abre un form en el panel en lugar de abrirlo en forma modal
        /// </summary>
        /// <param name="childForm"></param>
        private void abrirFormPequeño(Form childForm)
        {
            if(formActivo!=null)
            {
                formActivo.Close();
            }
            formActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle=FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormularioChico.Controls.Add(childForm);
            panelFormularioChico.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnFuncionAdmin_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuAdmin);
        }

        private void CustomizarDiseño()
        {
            panelSubMenuAdmin.Visible = false;
        }
        private void EsconderSubMenu()
        {
            if(panelSubMenuAdmin.Visible==true)
            {
                panelSubMenuAdmin.Visible = false;
            }
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


    }
}
