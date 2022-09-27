using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryArroyoSP1EpR
{
    public partial class frmConsultaVentas : Form
    {
        public frmConsultaVentas()
        {
            InitializeComponent();
        }

        private void frmConsultaVentas_Load(object sender, EventArgs e)
        {
            
            

            StreamReader srConsultasVentas = new StreamReader("./Ventas.txt");


            while (!srConsultasVentas.EndOfStream)
            {
                string line = srConsultasVentas.ReadLine();
                string[] vecDatosVentas = line.Split(';') ;
                dgvConsultaVentas.Rows.Add(vecDatosVentas[0], vecDatosVentas[1], vecDatosVentas[2], vecDatosVentas[3], vecDatosVentas[4], vecDatosVentas[5]);
            }
            srConsultasVentas.Close();
        }

        private void cmdLimpiarConsultaCliente_Click(object sender, EventArgs e)
        {
            dgvConsultaVentas.Rows.Clear();
        }

        private void dgvConsultaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            StreamReader srConsultasVentas = new StreamReader("./Ventas.txt");


            while (!srConsultasVentas.EndOfStream)
            {
                string line = srConsultasVentas.ReadLine();
                string[] vecDatosVentas = line.Split(';');
                dgvConsultaVentas.Rows.Add(vecDatosVentas[0], vecDatosVentas[1], vecDatosVentas[2], vecDatosVentas[3], vecDatosVentas[4], vecDatosVentas[5]);
            }
            srConsultasVentas.Close();
        }
    }
}
