using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DYNAMICS.UI
{


    public partial class mantenimientoPrincipal : Form
    {


        public mantenimientoPrincipal()
        {
            InitializeComponent();
        }

        private void mantenimientoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoCliente.mantenimientoClientePrincipal mantenimiento;
            mantenimiento = new mantenimientoCliente.mantenimientoClientePrincipal();
            mantenimiento.ShowDialog();
        }
    }
}
