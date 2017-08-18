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
    public partial class mantenimientoClienteFiltroNombre : Form
    {

        private string nombre;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public mantenimientoClienteFiltroNombre()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Nombre = txtNombre.Text;
            }catch (Exception ex) {
                MessageBox.Show("Problemas al filtrar Los datos. El error especifico es: " + ex);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
