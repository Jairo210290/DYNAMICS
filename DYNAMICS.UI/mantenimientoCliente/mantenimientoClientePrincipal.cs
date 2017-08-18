using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DYNAMICS.UI.mantenimientoCliente
{
    public partial class mantenimientoClientePrincipal : Form
    {
        static List<BE.Cliente> lista = new List<BE.Cliente>();
        private BS.mantenimientoCliente mantenimientoBS;

        public mantenimientoClientePrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mantenimientoClienteAgregar mantenimiento = new mantenimientoClienteAgregar();
            mantenimiento.ShowDialog();
            Refrescar();
        }

        public void Refrescar() {
            mantenimientoBS = new BS.mantenimientoCliente();
            lista= mantenimientoBS.Listar();
            this.dgLista.DataSource = lista;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void mantenimientoClientePrincipal_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            string id2="";
            if (dgLista.SelectedRows.Count== 1 ) {

                foreach (DataGridViewRow dgvRow in dgLista.SelectedRows)
                {
                    id2 = dgLista.CurrentRow.Cells[0].Value.ToString();
                }

                mantenimientoClienteEditar mantenimiento = new mantenimientoClienteEditar();
                mantenimiento.IdCliente = int.Parse(id2);
                mantenimiento.ShowDialog();
                Refrescar();
            }else{
                MessageBox.Show("Debes seleccionar una fila");
            }

        }

        private void btnNombre_Click(object sender, EventArgs e){//inicio metodo boton filtrar nombre
            string Nombre = "";
            mantenimientoClienteFiltroNombre mantenimiento = new mantenimientoClienteFiltroNombre();
            mantenimiento.ShowDialog();
            Nombre = mantenimiento.Nombre;
            
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista.ElementAt(i).Nombre!= Nombre)
                {
                    lista.RemoveAt(i);
                    i--;
                }
            }
            dgLista.DataSource = null;
            dgLista.DataSource = lista;
        }//fin metodo boton filtrar nombre

        private void btnApellido_Click(object sender, EventArgs e)
        {
            string Apellido = "";
            mantenimientoClienteFiltroApellido mantenimiento = new mantenimientoClienteFiltroApellido();
            mantenimiento.ShowDialog();
            Apellido = mantenimiento.Apellido;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista.ElementAt(i).Apellido != Apellido)
                {
                    lista.RemoveAt(i);
                    i--;
                }
            }
            dgLista.DataSource = null;
            dgLista.DataSource = lista;
        }
    }
}
