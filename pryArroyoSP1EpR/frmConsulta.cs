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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

            char caracter;

            string espacio = " ";
            caracter = Convert.ToChar(espacio);

            StreamReader srConsultas = new StreamReader("./Clientes.txt");
            

            while (!srConsultas.EndOfStream)
            {
                string line = srConsultas.ReadLine();
                string[] vecDatosClientes = line.Split(caracter);
                dgvConsulta.Rows.Add(vecDatosClientes[0], vecDatosClientes[1]);
            }
            srConsultas.Close();
            
            
            














        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmdLimpiarConsultaCliente_Click(object sender, EventArgs e)
        {
            dgvConsulta.Rows.Clear();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            char caracter;

            string espacio = " ";
            caracter = Convert.ToChar(espacio);

            StreamReader srConsultas = new StreamReader("./Clientes.txt");


            while (!srConsultas.EndOfStream)
            {
                string line = srConsultas.ReadLine();
                string[] vecDatosClientes = line.Split(caracter);
                dgvConsulta.Rows.Add(vecDatosClientes[0], vecDatosClientes[1]);
            }
            srConsultas.Close();
        }
    }
}
