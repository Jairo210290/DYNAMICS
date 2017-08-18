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
    public partial class mantenimientoClienteFiltroApellido : Form
    {

        private string apellido;

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public mantenimientoClienteFiltroApellido()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Apellido = txtApellido.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al filtrar Los datos. El error especifico es: " + ex);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
