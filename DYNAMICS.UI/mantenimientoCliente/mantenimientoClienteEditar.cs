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
    public partial class mantenimientoClienteEditar : Form
    {

        private BS.mantenimientoCliente mantenimientoBS = new BS.mantenimientoCliente();
        private BE.Cliente mantenimientoBE = new BE.Cliente();
        private int mId;

        public int IdCliente
        {
            get
            {
                return this.mId;
            }
            set
            {
                this.mId = value;
            }
        }

        public mantenimientoClienteEditar()
        {
            InitializeComponent();
        }

        private void mantenimientoClienteEditar_Load(object sender, EventArgs e)
        {
            mantenimientoBS = new BS.mantenimientoCliente();
            mantenimientoBE = mantenimientoBS.ObtenerCliente(IdCliente);

            txtNombre.Text = mantenimientoBE.Nombre;
            txtApellido.Text = mantenimientoBE.Apellido;
            txtTelefono1.Text = mantenimientoBE.Telefono1;
            txtTelefono2.Text = mantenimientoBE.Telefono2;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            mantenimientoBE = new BE.Cliente();
            mantenimientoBS = new BS.mantenimientoCliente();

            mantenimientoBE.IdCliente = IdCliente;
            mantenimientoBE.Nombre = txtNombre.Text;
            mantenimientoBE.Apellido = txtApellido.Text;
            mantenimientoBE.Telefono1 = txtTelefono1.Text;
            mantenimientoBE.Telefono2 = txtTelefono2.Text;

            try
            {
                if (mantenimientoBS.Editar(mantenimientoBE) == true)
                {
                    MessageBox.Show("Datos editados correctamente");
                }
                else
                {
                    MessageBox.Show("Datos editados incorrectamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al Editar los datos. El error especifico es: " + ex);
            };

            this.DialogResult = DialogResult.OK;
        }
    }
}
