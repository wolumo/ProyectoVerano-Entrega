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
    public partial class frmCrearViaje : Form
    {
        string logon;
        public frmCrearViaje(string logon)
        {
            InitializeComponent();
            this.logon = logon;
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            int idContrato = int.Parse(txtIdContrato.Text);
            string EstadoContrato;
            SqlConnection connect = new SqlConnection(logon);
            connect.Open();
            string query = "select Estado from Contrato where id_Contrato  =  " +
             idContrato ;
            SqlCommand command = new SqlCommand(query, connect);
            EstadoContrato = Convert.ToString(command.ExecuteScalar());
            if (EstadoContrato == "Sin Cancelar")
            {
                MessageBox.Show("Debes de pagar el contrato para generar un viaje.");
            }else
            if (EstadoContrato == "Cancelado")
            {
             
                cmbPiloto.Enabled = true;
                cmbCamiones.Enabled = true;
                string query2 = "select Peso from Contrato where id_Contrato =  " + idContrato;
                SqlCommand command1 = new SqlCommand(query2,connect);
                string Peso = Convert.ToString(command1.ExecuteScalar());
                txtPeso.Text = Peso;
                string query3 = "select suc.Direccion from Contrato as con inner join Sucursal as suc on con.id_Sucursal = suc.id_sucursal where con.id_Contrato =  "+ idContrato;
                SqlCommand command2 = new SqlCommand(query3,connect);
                string NombreSuc = Convert.ToString(command2.ExecuteScalar());
                txtSucursal.Text = NombreSuc;
                cmbProducto.Enabled = true;
                txtPeso.ReadOnly = true;
                string query4 = "select id_sucursal from Sucursal where Direccion = '" + NombreSuc + "'";
                SqlCommand command3 = new SqlCommand(query4, connect);
                string IdSucursal = Convert.ToString(command3.ExecuteScalar());
                int IdSucursalVerd = int.Parse(IdSucursal);
                DViaje dViaje = new DViaje(logon);
               cmbCamiones.DataSource = dViaje.CargarCamionesLibres(IdSucursalVerd);
                cmbCamiones.DisplayMember = "modelo";
                cmbCamiones.ValueMember = "modelo";

                cmbPiloto.DataSource = dViaje.CargarPilotosLibres(IdSucursalVerd);
                cmbPiloto.DisplayMember = "NombrePilotos";
                cmbPiloto.DisplayMember = "NombrePilotos";

                string query5 = "select pro.id_Cliente from Contrato as con inner join Producto as pro on con.RucCliente = pro.id_Cliente where con.id_Contrato = " + idContrato;
                SqlCommand command4 = new SqlCommand(query5, connect);
                int IdCliente = int.Parse(Convert.ToString(command4.ExecuteScalar()));

                cmbProducto.DataSource = dViaje.CargarProductos(IdCliente);
                cmbProducto.DisplayMember = "NombreP";
                cmbProducto.ValueMember = "NombreP";


            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(logon);
            connect.Open();
            int idContrato = int.Parse(txtIdContrato.Text);
            string query3 = "select suc.Direccion from Contrato as con inner join Sucursal as suc on con.id_Sucursal = suc.id_sucursal where con.id_Contrato =  " + idContrato;
            SqlCommand command2 = new SqlCommand(query3, connect);
            string NombreSuc = Convert.ToString(command2.ExecuteScalar());

            string query4 = "select id_sucursal from Sucursal where Direccion = '" + NombreSuc + "'";
            SqlCommand command3 = new SqlCommand(query4, connect);
            string IdSucursal = Convert.ToString(command3.ExecuteScalar());
            int IdSucursalVerd = int.Parse(IdSucursal);
            int idPiloto = cmbPiloto.SelectedIndex + 1;
            int idCamion = cmbCamiones.SelectedIndex + 1;
            DViaje dViaje = new DViaje(logon);
            dViaje.InsertarViaje(idContrato,IdSucursalVerd,idPiloto,idCamion);
            connect.Close();
        }
    }
}
