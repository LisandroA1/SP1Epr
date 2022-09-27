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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            bool Bandera = false; //bandera para habilitar o deshabilitar a la hora de grabar 

            if (File.Exists("./Clientes.txt"))
            {
                StreamReader srNumeroClientes = new StreamReader("./Clientes.txt"); //Creo un StreamReader para leer el archivo 

                while (!srNumeroClientes.EndOfStream)//mientras sea diferente a fin de archivo
                {
                    string auxCliente = srNumeroClientes.ReadLine();

                    if (mtbNumeroCliente.Text == auxCliente.Substring(0, 3)) //Comparo si desde la posicion numero 0 a la 3 se repiten para que no lo deje grabar
                    {
                        MessageBox.Show("Este codigo ya se encuentra cargado, intente de nuevo");
                        txtCliente.Text = "";
                        mtbNumeroCliente.Text = "";
                        mtbNumeroCliente.Focus();
                        Bandera = true; //si se repite la bandera sera verdadera por lo tanto no lo dejara grabar

                    }

                }
                srNumeroClientes.Close();
            }

            if (Bandera == false) //si no se repite la bandera sera falsa por lo tanto podra grabar con normalidad
            {
                StreamWriter Clientes = new StreamWriter("./Clientes.txt", true); //creo un streamwriter para escribir el archivo

                //escribo el archivo con sus respectivos datos 
                Clientes.WriteLine(mtbNumeroCliente.Text + " " + txtCliente.Text);
                MessageBox.Show("Cliente cargado con exito"); //muestro un mensaje
                Clientes.Close();//cierro el archivo
                //limpio los controles
                mtbNumeroCliente.Text = "";
                txtCliente.Text = "";
                mtbNumeroCliente.Focus();
            }
            
            
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Clientes.txt");
            MessageBox.Show("Archivo borrado con exito");
        }
    }
}
