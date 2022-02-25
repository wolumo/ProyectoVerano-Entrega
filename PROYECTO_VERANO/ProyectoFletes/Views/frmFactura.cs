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
    public partial class frmFactura : Form
    {
        fmCrearContrato fmcs;
        string logon;
        public frmFactura(fmCrearContrato fmcs, string logon)
        {
            InitializeComponent();
            this.fmcs = fmcs;
            this.logon = logon;
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(logon);
            connect.Open();
            string query = " select id_Contrato from Contrato inner join Sucursal on Contrato.id_Sucursal = Sucursal.id_sucursal where Sucursal.Direccion = '" +
             fmcs.cmbSucursales.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(query, connect);
            int Idsucursal = Convert.ToInt32(command.ExecuteScalar());
            // TODO: esta línea de código carga datos en la tabla 'dataPrincipal.FACTURA' Puede moverla o quitarla según sea necesario.
            this.fACTURATableAdapter.Fill(this.dataPrincipal.FACTURA, Idsucursal);

            this.reportViewer1.RefreshReport();
        }
    }
}
