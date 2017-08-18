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
    public partial class mantenimientoClienteAgregar : Form
    {

        private BE.Cliente mMantenimientoBE;
        private BS.mantenimientoCliente mMantenimientoBS;

        public mantenimientoClienteAgregar()
        {
            InitializeComponent();
        }

        private void btAceptacion_Click(object sender, EventArgs e)
        {
            mMantenimientoBE = new BE.Cliente();
            mMantenimientoBS = new BS.mantenimientoCliente();

            mMantenimientoBE.Nombre = txtNombre.Text;
            mMantenimientoBE.Apellido = txtApellido.Text;
            mMantenimientoBE.Telefono1 = txtTelefono1.Text;
            mMantenimientoBE.Telefono2 = txtTelefono2.Text;

            try
            {
                if (mMantenimientoBS.Agregar(mMantenimientoBE)==true) {
                    MessageBox.Show("Datos ingresados correctamente");
                }else
                {
                    MessageBox.Show("Datos ingresados incorrectamente");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Problemas al Insertar los datos. El error especifico es: " + ex);};

            this.DialogResult = DialogResult.OK;
        }
    }
}
