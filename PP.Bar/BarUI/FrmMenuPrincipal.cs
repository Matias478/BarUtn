using BarLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace BarUI
{
    public partial class FrmMenuPrincipal : Form
    {
        Persona usuarioLogueado;
        static Dictionary<int, Button> botones;
        static Dictionary<int, bool> disponibilidadMesas;
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
            lblWelcome.Text += "Bienvenido al Bar-UTN "+ usuarioLogueado.Nombre;
            EsAdmin(usuarioLogueado);
            CargarSonidoAmbiente();
        }

        public static void CargarSonidoAmbiente()
        {
            try
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.RuidoAmbiente);
                sp.PlayLooping();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Verifica si el usuario ingresado es admin o un empleado normal 
        /// y cambia la visibildad de los botones que controlan las funciones del admin, tambien carga diferentes imagenes dependiendo si es admin o empleado
        /// </summary>
        /// <param name="usuario"></param>
        private void EsAdmin(Persona usuario)
        {
            if (usuario.EsAdmin == false)
            {
                btnFuncionAdmin.Visible = false;
                btnFuncionEmpleado.Visible = true;
                btnInventario.Visible = false;
                try
                {
                    Bitmap image = new Bitmap(Properties.Resources.meseros);
                    panelFormularioChico.BackgroundImage = image;
                    panelFormularioChico.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nose pudo encontrar la imagen del empleado");
                }
            }
            else
            {
                try
                {
                    Bitmap image = new Bitmap(Properties.Resources.Administrador);
                    panelFormularioChico.BackgroundImage = image;
                    panelFormularioChico.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Imagen de empleado no encontrada");
                }
            }

        }

        /// <summary>
        /// Instancia el dictionary de botones y agrega los 20 botones de mesas/barra
        /// </summary>
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
        /// Las recorre y segun su value pinta el boton en verde si estan libres y rojas sino lo estan
        /// </summary>
        public static void ObtenerEstadoMesas()
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
            if (MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                e.Cancel = true;
        }

        /// <summary>
        /// Recorre el dictionary botones, verifica que el valor sea igual a Button(auxBtn en este caso)
        /// Luego verifica si la lista de productos de la mesa es null, de ese ser el caso llama a instanciar lista
        /// Para despues llamar al metodo que muestra el form dentro de los limites del panel y llama a ObtenerEstadoMesas() de nuevo para cambiar el color de las mesas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mesas_Click(object sender, EventArgs e)
        {
            Button auxBtn = (Button)sender;

            foreach (KeyValuePair<int, Button> item in botones)
            {
                if (item.Value == auxBtn)
                {
                    if (Bar.Mesas[item.Key].Producto == null)
                    {
                        Bar.Mesas[item.Key].InstanciarLista(item.Key + 1);
                    }
                    abrirFormPequeño(new FrmMenu(item.Key));
                    ObtenerEstadoMesas();
                }
            }
        }

        /// <summary>
        /// Abre el FrmLista pasadole por parametros que tipo de lista se quiere mostrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListaEmpleados_Click(object sender, EventArgs e)
        {
            string tipoLista = "ListaEmpleados";// indica que tipo de lista mostrara
            abrirFormPequeño(new FrmLista(tipoLista));
            //EsconderSubMenu();
        }

        /// <summary>
        /// Abre un form dentro los limites de un panel en lugar de abrirlo en forma modal
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

        /// <summary>
        /// Abre el sub-menu para acceder a las funciones del admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFuncionAdmin_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuAdmin);
        }

        #region SubMenu
        private void CustomizarDiseño()
        {
            panelSubMenuAdmin.Visible = false;
            panelSubMenuEmpleado.Visible = false;
            panelSubMenuInventario.Visible = false;
        }
        private void EsconderSubMenu()
        {
            if (panelSubMenuAdmin.Visible == true)
            {
                panelSubMenuAdmin.Visible = false;
            }
            if (panelSubMenuEmpleado.Visible == true)
            {
                panelSubMenuEmpleado.Visible = false;
            }
            if (panelSubMenuInventario.Visible == true)
            {
                panelSubMenuInventario.Visible = false;
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

        /// <summary>
        /// Abre el form para poder llenar los datos para agregar un empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormPequeño(new FrmAgregarEmpleado());
        }

        /// <summary>
        /// Abre el sub-menu para acceder a las funciones del empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFuncionEmpleado_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuEmpleado);
        }

        /// <summary>
        /// Abre el FrmLista pasadole por parametros que tipo de lista se quiere mostrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoMesas_Click(object sender, EventArgs e)
        {
            string tipoLista = "ListaMesas";// indica que tipo de lista mostrara
            abrirFormPequeño(new FrmLista(tipoLista));
        }

        /// <summary>
        /// Abre un form para elegir y remover empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoverEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormPequeño(new FrmRemoverEmpleado());
        }

        /// <summary>
        /// Abre el sub-Menu de inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventario_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuInventario);
        }
        /// <summary>
        /// Abre el FrmLista pasadole por parametros que tipo de lista se quiere mostrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfoInventario_Click(object sender, EventArgs e)
        {
            string tipoLista = "ListaInventario";// indica que tipo de lista mostrara
            abrirFormPequeño(new FrmLista(tipoLista));
        }

        /// <summary>
        /// Abre el form para agregar productos al inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            abrirFormPequeño(new FrmAgregarProductos());
        }


    }
}
