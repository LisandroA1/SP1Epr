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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            bool Bandera = false; //bandera para habilitar o deshabilitar a la hora de grabar 
            string varActivo = "Activo No";
            string varComision = "Comision No";

            if (chkActivo.Checked == true)
            {
                varActivo = "Activo Si";
            }

            if (chkComision.Checked == true)
            {
                varComision = "Comisión Si";
            }


            if (File.Exists("./Vendedor.txt"))
            {
                StreamReader srNumeroVendedor = new StreamReader("./Vendedor.txt", true); //Creo un StreamReader para leer el archivo 
                while (!srNumeroVendedor.EndOfStream) //mientras sea diferente a fin de archivo
                {

                    string auxVendedor = srNumeroVendedor.ReadLine();

                    if (mtbNumeroVendedor.Text == auxVendedor.Substring(0, 3)) //Comparo si desde la posicion numero 0 a la 3 se repiten para que no lo deje grabar
                    {
                        MessageBox.Show("Este codigo ya se encuentra cargado, intente de nuevo");
                        txtVendedor.Text = "";
                        mtbNumeroVendedor.Text = "";
                        mtbNumeroVendedor.Focus();
                        Bandera = true; //si se repite la bandera sera verdadera por lo tanto no lo dejara grabar

                    }

                }
                srNumeroVendedor.Close();

               
            }
            if (Bandera == false) //si no se repite la bandera sera falsa por lo tanto podra grabar con normalidad
            {
                StreamWriter Vendedor = new StreamWriter("./Vendedor.txt", true); //creo un streamwriter para escribir el archivo

                //escribo el archivo con sus respectivos datos 
                Vendedor.WriteLine(mtbNumeroVendedor.Text + " " + txtVendedor.Text + " " + varActivo + " " + varComision);
                MessageBox.Show("Vendedor cargado con exito"); //muestro un mensaje
                Vendedor.Close(); //cierro el archivo
                //limpio los controles
                mtbNumeroVendedor.Text = "";
                txtVendedor.Text = "";
                mtbNumeroVendedor.Focus();
            }
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {
           
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Vendedor.txt");
            MessageBox.Show("Archivo borrado con exito");
        }
    }
}
