
using ProyectoFletes.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFletes.Data;
using System.Threading;
using System.Data.SqlClient;

namespace ProyectoFletes
{
    public partial class Form1 : Form
    {
        
        public  string ConexionString()
        {
            return @"Data Source=DESKTOP-JNDQ2L1;Initial Catalog=RyW;UID=" + txtUsername.Text +";PWD=" + txtPassword.Text;
        }
        
        Conexion con;
        FrmMain f1;
        int cont =3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar el sistema!");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
       
            // Aqui faltan los roles jaja
            // aqui estan cochon jajaj
            con = new Conexion(txtUsername.Text, txtPassword.Text);
            string logon = @"Data Source=DESKTOP-JNDQ2L1;Initial Catalog=RyW;UID=" + txtUsername.Text + ";PWD=" + txtPassword.Text;
    
            if (this.con.connect.State == ConnectionState.Open)
            {
                Console.WriteLine("JueputaRola");
                MessageBox.Show("Bienvenido al sistema!");
                f1 = new FrmMain(con, logon);
               
                    f1.Show();
                    this.Hide();
            }else
            {              
                --cont;
                MessageBox.Show("Error:usuario o contrasenia incorrecta ", cont + " Intentos restantes");
                if (cont == 0)
                {
                    cont = 3;
                    button1.Enabled = false;
                    Thread.Sleep(3000);
                    button1.Enabled = true;

                }
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        public  string getUsuario()
        {
            string user = txtUsername.Text;
            return user;
        }
        public string getPass()
        {
            string pass = txtPassword.Text;
            return pass; 
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
