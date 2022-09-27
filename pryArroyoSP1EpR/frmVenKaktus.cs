using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArroyoSP1EpR
{
    public partial class frmVenKaktus : Form
    {
        public frmVenKaktus()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes newObject = new frmClientes();
            newObject.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedor newObject = new frmVendedor();
            newObject.ShowDialog();
        }

        private void consultaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta newObject = new frmConsulta();
            newObject.ShowDialog();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVentas newObjetc = new frmConsultaVentas();
            newObjetc.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmVentas newObject = new frmVentas();
            newObject.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
