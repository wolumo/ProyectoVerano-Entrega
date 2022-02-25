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
    public partial class fmCrearContrato : Form
    {
        DContrato dContrato;
        Conexion con;
        string logon;
        public fmCrearContrato fmcs;

        public fmCrearContrato()
        {

        }
        public fmCrearContrato(string logon)
        {
            this.logon = logon;
        }
        public fmCrearContrato(Conexion con, string logon, DContrato dContrato)
        {
            InitializeComponent();
            this.con = con;
            this.logon = logon;
            this.dContrato = dContrato;
            CargarSucursales(logon);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fmCrearContrato_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            btnFacturar.Visible = true;
            SqlConnection connect = new SqlConnection(logon);
            connect.Open();
            string query = "select id_sucursal from Sucursal where Direccion =  '" +
             cmbSucursales.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(query, connect);
            int Idsucursal = Convert.ToInt32(command.ExecuteScalar());
           
            DateTime FechaPro = dtmFechaPronos.Value;
            string RucCliente = txtRuc.Text;
            string LugarSalida = txtLugarSalida.Text;
            string LugarLlegada = txtNombreLLegada.Text;
            float Peso = float.Parse(txtPeso.Text);

            dContrato.InsertarContrato(Idsucursal,FechaPro,RucCliente,LugarSalida,LugarLlegada,Peso);

            float subTotal = float.Parse(txtMonto.Text);
            float Descuento = float.Parse(txtDescV.Text);
            float LatitudSalida = float.Parse(txtLatitudS.Text);
            float LongitudSalida = float.Parse(txtLongitudS.Text);
            float LatitudLlegada = float.Parse(txtLatLLegada.Text);
            float LongitudLlegada = float.Parse(txtLongLLegada.Text);
            float Total = float.Parse(txtTotal.Text);

            dContrato.InsertarDetalleContrato(subTotal, Descuento,LatitudSalida,LongitudSalida,LatitudLlegada,
                LongitudLlegada,Total);


        }

        private void CargarSucursales(string logon)
        {
            cmbSucursales.DataSource = dContrato.CmbSucursal(logon);
            cmbSucursales.DisplayMember = "Direccion";
            cmbSucursales.ValueMember = "Direccion";
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            float km = float.Parse(txtDistanciaKm.Text);
            float PrecioPeso =0; 
            if(float.Parse(txtPeso.Text) < 19)
            {
                PrecioPeso = 2200;
            }
            if (float.Parse(txtPeso.Text) > 19 && float.Parse(txtPeso.Text) <26)
            {
                PrecioPeso = 3600;
            }
            if(float.Parse(txtDistanciaKm.Text)>26)
            {
                PrecioPeso = 4200;
            }
            float GasolinaPrecio = float.Parse(txtGasolinaPrecio.Text);
            float Litros = 42/100;
            float SubTotal = ((Litros* GasolinaPrecio)/1)+PrecioPeso;

            txtMonto.Text = Convert.ToString(SubTotal);
            txtImpuesto.Text = Convert.ToString(SubTotal*0.15);
            txtTotal.Text = Convert.ToString(SubTotal + (SubTotal*0.15));


        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            if (fmcs == null)
            {
                Console.WriteLine("olaola");
            }
            MapaContrato mapaContrato = new MapaContrato(logon, fmcs);
            //mapaContrato.fmcs = fmcs;
            mapaContrato.Show();
        }

        private void txtImpuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void txtDescV_TextChanged(object sender, EventArgs e)
        {
            float Descuento = float.Parse(txtDescV.Text);
            txtDescuento.Text = Convert.ToString((float.Parse(txtMonto.Text) +
                float.Parse(txtImpuesto.Text)) * Descuento);

            txtTotal.Text = Convert.ToString((float.Parse(txtMonto.Text)+float.Parse(txtImpuesto.Text))-
                float.Parse(txtDescuento.Text));

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            frmFactura frmFactura = new frmFactura(fmcs,logon);
            frmFactura.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            btnFacturar.Visible = true;
            SqlConnection connect = new SqlConnection(logon);
            connect.Open();
            string query = "select id_sucursal from Sucursal where Direccion =  '" +
             cmbSucursales.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(query, connect);
            int Idsucursal = Convert.ToInt32(command.ExecuteScalar());

            DateTime FechaPro = dtmFechaPronos.Value;
            string RucCliente = txtRuc.Text;
            string LugarSalida = txtLugarSalida.Text;
            string LugarLlegada = txtNombreLLegada.Text;
            float Peso = float.Parse(txtPeso.Text);
            int idContrato = int.Parse(txtIdContrato.Text);
            dContrato.ActualizarContrato(idContrato, Idsucursal, FechaPro,
                RucCliente, LugarSalida, LugarLlegada, Peso);

            float subTotal = float.Parse(txtMonto.Text);
            float Descuento = float.Parse(txtDescV.Text);
            float LatitudSalida = float.Parse(txtLatitudS.Text);
            float LongitudSalida = float.Parse(txtLongitudS.Text);
            float LatitudLlegada = float.Parse(txtLatLLegada.Text);
            float LongitudLlegada = float.Parse(txtLongLLegada.Text);
            float Total = float.Parse(txtTotal.Text);

            dContrato.ActualizarDetalleContrato(idContrato, subTotal, Descuento,
                LatitudSalida, LongitudSalida, LatitudLlegada, LongitudLlegada, Total);

        }
    }
}
