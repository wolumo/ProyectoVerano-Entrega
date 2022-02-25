using ProyectoFletes.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFletes.Views
{
    public partial class FrmMain : Form
    {
         Conexion con;
        public string logon; 
        frmCrearSucursal cs;
  
        frmCrearProducto crearProducto;
        public DataTable dataEmpleado = new DataTable();
        public FrmMain()
        {
            
            InitializeComponent();
        }
        public FrmMain(Conexion cone , string logon)
        {
           
            InitializeComponent();
            this.con = cone;
            this.logon = logon;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPilotos_Click(object sender, EventArgs e)
        {
            pnlSubMenuPiloto.Visible = true;

            frmCrearSucursal cs = new frmCrearSucursal(con,logon);
            cs.cs = cs;
            cs.Show();
        }

        private void btnCrearPi_Click(object sender, EventArgs e)
        {
            pnlSubMenuPiloto.Visible = false;
        }

        private void btnVerPilotos_Click(object sender, EventArgs e)
        {
            pnlSubMenuPiloto.Visible = false; 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar el sistema!");
            Application.Exit();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = true; 

        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            if (con.connect.State == ConnectionState.Open)
            {
              
                DProducto dProducto = new DProducto(con , logon);
               frmCrearProducto frmCrearProducto = new frmCrearProducto(con, logon, dProducto  );
                frmCrearProducto.Show(); 
            }
        }

        private void btnCrearContrato_Click(object sender, EventArgs e)
        {
            if(con.connect.State == ConnectionState.Open)
            {
                DContrato dContrato = new DContrato(con, logon);
                fmCrearContrato fmcs = new fmCrearContrato(con , logon, dContrato);
                fmcs.fmcs = fmcs;
                fmcs.Show();
                pnlContrato.Visible = false;
            }
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            pnlContrato.Visible = true; 

        }

        private void btnAdministrarCon_Click(object sender, EventArgs e)
        {
          
            AdministrarContratos administrarContratos = new AdministrarContratos(logon);
            
            administrarContratos.Show();
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            pnlViajes.Visible = true;
        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            frmCrearViaje frmCrearViaje = new frmCrearViaje(logon);
            frmCrearViaje.Show();
            pnlViajes.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdministrarViajes administrarViajes = new AdministrarViajes(logon);
            administrarViajes.Show();
            pnlViajes.Visible = false;
        }
    }
}
