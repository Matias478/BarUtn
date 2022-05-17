using BarLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BarUI
{
    public partial class FrmMenuPrincipal : Form
    {
        Persona usuarioLogueado;
        Dictionary<int, Button> botones;
        //Dictionary<int, bool> disponibilidadMesas;
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
            //ObtenerEstadoMesas();
            lblWelcome.Text += usuarioLogueado.Nombre;
            EsAdmin(usuarioLogueado);
        }

        private void EsAdmin(Persona usuario)
        {
            if (usuario.EsAdmin == false)
            {
                btnFuncionAdmin.Visible = false;
                btnFuncionEmpleado.Visible = true;
            }
        }

        private void CargarMesas()
        {
            botones = new Dictionary<int, Button>();

            botones.Add(0, btnMesa1);
            botones.Add(1, btnMesa2);
            botones.Add(2, btnMesa3);
            botones.Add(3, btnMesa4);
            botones.Add(4, btnMesa5);
            botones.Add(5, btnMesa6);
            botones.Add(6, btnMesa7);
            botones.Add(7, btnMesa8);
            botones.Add(8, btnMesa9);
            botones.Add(9, btnMesa10);
            botones.Add(10, btnMesa11);
            botones.Add(11, btnMesa12);
            botones.Add(12, btnMesa13);
            botones.Add(13, btnMesa14);
            botones.Add(14, btnMesa15);
            botones.Add(15, btnBarra16);
            botones.Add(16, btnBarra17);
            botones.Add(17, btnBarra18);
            botones.Add(18, btnBarra19);
            botones.Add(19, btnBarra20);
        }

        /// <summary>
        /// Usa el metodo EstadoMesas que devuelve una lista de mesas con ningun producto
        /// Las recorre y segun su value pinta el boton en verde si estan libres y rojas sino
        /// </summary>
        //private void ObtenerEstadoMesas()
        //{
        //    disponibilidadMesas = Bar.EstadoMesas();

        //    foreach (KeyValuePair<int, bool> mesa in disponibilidadMesas)
        //    {
        //        if (mesa.Value)
        //        {
        //            botones[mesa.Key].BackColor = Color.LightGreen;
        //        }
        //        else { botones[mesa.Key].BackColor = Color.IndianRed; }
        //    }
        //}

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
               Application.Exit();
            }
        }
            

        private void btn_mesas_Click(object sender, EventArgs e)
        {
            Button auxBtn = (Button)sender;

            foreach (KeyValuePair<int, Button> item in botones)
            {
                if (item.Value == auxBtn)
                {
                    //MessageBox.Show(Bar.MostrarMesa(item.Key));
                    abrirFormPequeño(new FrmMenu(item.Key));
                }
            }
        }

        private void btnListaEmpleados_Click(object sender, EventArgs e)
        {
            bool tipoLista=true;//si es true muestra la lista de empleados
            abrirFormPequeño(new FrmLista(tipoLista));
            //EsconderSubMenu();
        }

        /// <summary>
        /// Abre un form en el panel en lugar de abrirlo en forma modal
        /// </summary>
        /// <param name="childForm"></param>
        private void abrirFormPequeño(Form childForm)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
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

        #region SubMenu
        private void CustomizarDiseño()
        {
            panelSubMenuAdmin.Visible = false;
            panelSubMenuEmpleado.Visible = false;
        }
        private void EsconderSubMenu()
        {
            if (panelSubMenuAdmin.Visible == true)
            {
                panelSubMenuAdmin.Visible = false;
            }
            if(panelSubMenuEmpleado.Visible==true)
            {
                panelSubMenuEmpleado.Visible = false;
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

        #endregion

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormPequeño(new FrmAgregarEmpleado());
        }

        private void btnFuncionEmpleado_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuEmpleado);
        }

        private void btnInfoMesas_Click(object sender, EventArgs e)
        {
            bool tipoLista=false;// si es false muestra la lista de mesas
            abrirFormPequeño(new FrmLista(tipoLista));
        }

        private void btnRemoverEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormPequeño(new FrmRemoverEmpleado());

        }
    }
}
