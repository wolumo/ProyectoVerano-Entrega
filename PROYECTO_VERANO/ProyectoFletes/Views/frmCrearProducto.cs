using ProyectoFletes.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFletes.Views
{
    public partial class frmCrearProducto : Form
    {
        string logon;
        public Conexion con;
        DProducto dProducto;
        
        public frmCrearProducto()
        {
            InitializeComponent();
            CargarClientes(logon);
            CargarCategorias();
        }

        public frmCrearProducto (Conexion con ,string logon , DProducto dProducto)
        {
            InitializeComponent();
            this.con = con;
            this.logon = logon;
            this.dProducto = dProducto;
            CargarClientes(logon);
            CargarCategorias();
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCrearProducto_Load(object sender, EventArgs e)
        {

        }

        private void CargarClientes(string logon)
        {
            cmbClientes.DataSource = dProducto.CargarClientes(logon);
            cmbClientes.DisplayMember = "NombreC";
            cmbClientes.ValueMember = "NombreC";
        }  

        private void CargarCategorias()
        {
          cmbCategoria.DataSource = dProducto.CargarCategorias(logon);
          cmbCategoria.DisplayMember = "NombreCat";
          cmbCategoria.ValueMember = "NombreCat";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string Cliente = cmbClientes.SelectedValue.ToString(); //oli
            SqlConnection connect = new SqlConnection(logon);
            connect.Open();
            string query = "Select RUC from Cliente where NombreC = '"+Cliente +"'";
            SqlCommand command = new SqlCommand(query , connect);
            string IdCliente = Convert.ToString(command.ExecuteScalar());
            string Categoria = cmbCategoria.SelectedValue.ToString();
            string query2 = "Select id_Cat from Categoria where NombreCat = '"+Categoria +"'";
            int IdCategoria = Convert.ToInt32(command.ExecuteScalar());
            string NombreProducto = txtNombreProducto.Text;
            string Descripcion = txtDescripcion.Text;
            //Validar aqui 

            dProducto.InsertarProducto(logon,IdCliente,IdCategoria,NombreProducto,Descripcion , connect);



        }
    }
}
