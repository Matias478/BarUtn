using BarLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BarUI
{
    public partial class FrmRemoverEmpleado : Form
    {
        List<Persona> auxLista;
        public FrmRemoverEmpleado()
        {
            InitializeComponent();
        }

        private void FrmRemoverEmpleado_Load(object sender, EventArgs e)
        {
            CargarListaEmpleados();
        }

        private void CargarListaEmpleados()
        {
            auxLista = Bar.ListaUsuarios;
            foreach (Persona item in auxLista)
            {
                LtbListaEmpleados.Items.Add(item);
            }
        }


        private void btnCerrarRemoverEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Recorre la lista de usuarios, usa un auxPersona para asignarle la persona/empleado que devuelve el FindById 
        /// Luego invoca la sobrecarga del operador == el cual devuelve si la lista contiene a esa persona/empleado
        /// Si la contiene la remueve, y carga de nuevo la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemover_Click(object sender, EventArgs e)
        {
            Persona auxPersona;
            foreach (Persona item in auxLista)
            {
                auxPersona = item.FindEmployee(auxLista, (Persona)LtbListaEmpleados.SelectedItem);
                if (auxLista==auxPersona)
                {
                    auxLista.Remove(auxPersona);
                    LtbListaEmpleados.Items.Clear();
                    CargarListaEmpleados();
                    break;
                }else
                {
                    MessageBox.Show("No se encontro el empleado");
                }
            }
        }



    }
}
