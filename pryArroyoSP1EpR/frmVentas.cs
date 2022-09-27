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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            bool Bandera = false; //bandera para habilitar o deshabilitar a la hora de grabar 

            if (File.Exists("./Ventas.txt"))
            {
                StreamReader srNumeroFactura = new StreamReader("./Ventas.txt"); //Creo un StreamReader para leer el archivo 

                while (!srNumeroFactura.EndOfStream) //mientras sea diferente a fin de archivo
                {
                    string auxVentas = srNumeroFactura.ReadLine();

                    if (mtbNumeroFactura.Text == auxVentas.Substring(2, 7)) //Comparo si desde la posicion numero 2 a la 7 se repiten para que no lo deje grabar
                    {
                        MessageBox.Show("Este codigo ya se encuentra cargado, intente de nuevo");
                        lstTipoFactura.SelectedIndex = 0;
                        mtbNumeroFactura.Text = "";
                        dtpFecha.Text = "";
                        mtbIDCliente.Text = "";
                        mtbIDVendedor.Text = "";
                        txtMonto.Text = "";
                        lstTipoFactura.Focus();
                        Bandera = true; //si se repite la bandera sera verdadera por lo tanto no lo dejara grabar

                    }

                }
                srNumeroFactura.Close();
            }

            if (Bandera == false) //si no se repite la bandera sera falsa por lo tanto podra grabar con normalidad
            {
                StreamWriter srVentas = new StreamWriter("./Ventas.txt", true); //creo un streamwriter para escribir el archivo
                
                //escribo el archivo con sus respectivos datos 
                srVentas.WriteLine(lstTipoFactura.Text + ";" + mtbNumeroFactura.Text + ";" + dtpFecha.Text + ";" + mtbIDCliente.Text + ";" + mtbIDVendedor.Text + ";" + txtMonto.Text);
                MessageBox.Show("Ventas cargada con exito"); //muestro un mensaje
                srVentas.Close(); //cierro el archivo
                
                //limpio los controles
                lstTipoFactura.SelectedIndex = 0;
                mtbNumeroFactura.Text = "";
                dtpFecha.Text = "";
                mtbIDCliente.Text = "";
                mtbIDVendedor.Text = "";
                txtMonto.Text = "";
                lstTipoFactura.Focus();
            }

            
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Ventas.txt");
            MessageBox.Show("Archivo borrado con exito");
        }
    }
}
