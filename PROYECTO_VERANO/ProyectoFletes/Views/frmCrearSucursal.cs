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
    public partial class frmCrearSucursal : Form
    {
        public Conexion con;

        public frmCrearSucursal cs;

        string logon;
        

        public frmCrearSucursal()
        {    
            InitializeComponent(); 
        }
        public frmCrearSucursal(Conexion con, string logon)
        {
           
            InitializeComponent();
            this.con = con;
            this.logon = logon;
           
        }

        private void CargarDepartamentos()
        {

            try
            {

                cmbDepartamento.DataSource = con.CmbDep();
            }
            catch (Exception)
            {
               
            }
            cmbDepartamento.DisplayMember="NombreDep";
            cmbDepartamento.ValueMember = "NombreDep";
            
           
        }

        private void CargarMunicipios()
        {
          
            //cmbMunicipio.DisplayMember = "NombreMuni";
            //cmbMunicipio.ValueMember = "NombreMuni";
            //cmbMunicipio.DataSource = con.CargarMuni(cmbDepartamento.SelectedIndex+1);
        }

        private void CargarComarca()
        {
            
            
            //cmbComarca.DisplayMember = "NombreComa";
            //cmbComarca.ValueMember = "NombreComa";
            //cmbComarca.DataSource = con.CargarComa(cmbMunicipio.SelectedIndex + 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCrearSucursal_Load(object sender, EventArgs e)
        {
            // CargarDepartamentos();
            CargarDepartamentos();
            
        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {
         
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMunicipios();
        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComarca();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
             if(txtNombre.Text == "")
            {
                MessageBox.Show("Por favor, digite el campo obligatorio Direccion");
            }else
            if (txtTel.Text == "")
            {
                MessageBox.Show("Por favor, digite el campo obligatorio Telefono");
            }else
            if (cmbDepartamento.Text == "")
            {
                MessageBox.Show("Por favor, seleccione un departamento");
            }
            else
            {
                string Direccion = txtNombre.Text;
                DateTime Antiguedad = dtmAntiguedad.Value;
                string Telefono = txtTel.Text;
                float Latitud = float.Parse(txtLatitud.Text);
                float Longitud = float.Parse(txtLongitud.Text);
                SqlConnection connect = new SqlConnection(logon);
                connect.Open();
                string query = "select id_dep from Departamento where NombreDep = '" + 
                 cmbDepartamento.SelectedValue.ToString() + "'";
                SqlCommand command = new SqlCommand(query, connect);
                int IdDep = Convert.ToInt32(command.ExecuteScalar());
                con.InsertarSucursal(Direccion,Antiguedad,Telefono,Latitud,Longitud,IdDep);

            }
            
        }

        private void bntMapa_Click(object sender, EventArgs e)
        {

            mapaSucursal mapaSucursal = new mapaSucursal();
            mapaSucursal.cs = cs;
            mapaSucursal.Show();
        }
    }
}
