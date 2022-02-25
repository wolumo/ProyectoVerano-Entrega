using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFletes.Data
{
    public class DContrato
    {
        private Conexion con;
        private string logon;

        public DContrato(Conexion con, string logon)
        {
            this.con = con;
            this.logon = logon;
        }
        public DContrato(string logon)
        {
            this.logon = logon;
        }

        public DataTable CmbSucursal(string logon)
        {
            SqlConnection connect = new SqlConnection(logon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CargarSucursales";
            cmd.Connection = connect;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        } 
            
        public void InsertarContrato(int idSucursal ,DateTime FechaPronos, string RucCliente , string LugarSalida
            , string LugarLlegada , float Peso)
        {
            string rpta = "";
            try
            {
                SqlConnection connect = new SqlConnection(logon);
                connect.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@idSucursal", SqlDbType.Int);
                param[0].Value = idSucursal;
          
                param[1] = new SqlParameter("@FechaPronosticada", SqlDbType.Date);
                param[1].Value = FechaPronos;
                param[2] = new SqlParameter("@RucCliente", SqlDbType.Char);
                param[2].Value = RucCliente;
                param[3] = new SqlParameter("@LugarSalida",SqlDbType.NVarChar);
                param[3].Value = LugarSalida;
                param[4] = new SqlParameter("@LugarLlegada", SqlDbType.NVarChar);
                param[4].Value = LugarLlegada;
                param[5] = new SqlParameter("@Peso", SqlDbType.Float);
                param[5].Value = Peso;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearContrato";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "Not ok";
                connect.Close();
            }
            catch (Exception)
            {

            }
        }
        public void InsertarDetalleContrato(float subTotal , float Descuento, float LatitudSalida, float LongitudSalida,
            float LatitudLlegada , float LongitudLlegada , float Total)
        {
            if (logon == null) 
            {
                Console.WriteLine("Esta siendo null");
            }
            string rpta = "";
            try
            {
                SqlConnection connect = new SqlConnection(logon);
                connect.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[7];
                param[0] = new SqlParameter("@subtotal" , SqlDbType.Float);
                param[0].Value = subTotal;
                param[1] = new SqlParameter("@Descuento", SqlDbType.Float);
                param[1].Value = Descuento;
                param[2] = new SqlParameter("@LatitudSalida" , SqlDbType.Float);
                param[2].Value = LatitudSalida;
                param[3] = new SqlParameter("@LongitudSalida", SqlDbType.Float);
                param[3].Value = LongitudSalida;
                param[4] = new SqlParameter("@LatitudLlegada", SqlDbType.Float);
                param[4].Value = LatitudLlegada;
                param[5] = new SqlParameter("@LongitudLlegada", SqlDbType.Float);
                param[5].Value = LongitudSalida;
                param[6] = new SqlParameter("@total", SqlDbType.Money);
                param[6].Value = Total;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarDetalleContrato";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);
                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "Not ok";

                MessageBox.Show("Se inserto Perfectamente!");
                connect.Close();
            }
            catch (Exception) 
            { 

            }
        }
        public void ListarConSinCancelar (DataGridView gridView )
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection connect = new SqlConnection(logon);
         
            connect.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarContratosSinCancelar";
            cmd.Connection = connect;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            gridView.DataSource = dt;
        }
        public void ListarConCancelado(DataGridView gridView)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection connect = new SqlConnection(logon);
            connect.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarContratosCancelados";
            cmd.Connection = connect;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            gridView.DataSource = dt;

        }

        public void CambiarEstadoCancelado (int idContrato)
        {
            string rpta = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection connect = new SqlConnection(logon);
                connect.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idContrato", SqlDbType.Int);
                param[0].Value = idContrato;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActulizarEstadoContratoCancelado";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "Not ok";

                MessageBox.Show("Se Cambio Perfectamente!");
                connect.Close();
            }
            catch (Exception)
            {

            }

        }

        public void ActualizarContrato(int idContrato, int idSucursal, DateTime FechaPronos, string RucCliente, string LugarSalida
           , string LugarLlegada, float Peso)
        {
            string rpta = "";
            try
            {
                SqlConnection connect = new SqlConnection(logon);
                connect.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[7];
                param[0] = new SqlParameter("@idContrato" , SqlDbType.Int);
                param[0].Value = idContrato;
                param[1] = new SqlParameter("@idSucursal", SqlDbType.Int);
                param[1].Value = idSucursal;

                param[2] = new SqlParameter("@FechaPronosticada", SqlDbType.Date);
                param[2].Value = FechaPronos;
                param[3] = new SqlParameter("@RucCliente", SqlDbType.Char);
                param[3].Value = RucCliente;
                param[4] = new SqlParameter("@LugarSalida", SqlDbType.NVarChar);
                param[4].Value = LugarSalida;
                param[5] = new SqlParameter("@LugarLlegada", SqlDbType.NVarChar);
                param[5].Value = LugarLlegada;
                param[6] = new SqlParameter("@Peso", SqlDbType.Float);
                param[6].Value = Peso;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizarContrato";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "Not ok";
                connect.Close();
            }
            catch (Exception)
            {

            }
        }

        public void ActualizarDetalleContrato(int idContrato, float subTotal, float Descuento, float LatitudSalida, float LongitudSalida,
            float LatitudLlegada, float LongitudLlegada, float Total)
        {
            if (logon == null)
            {
                Console.WriteLine("Esta siendo null");
            }
            string rpta = "";
            try
            {
                SqlConnection connect = new SqlConnection(logon);
                connect.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[8];
                param[0] = new SqlParameter("@idContrato", SqlDbType.Int);
                param[0].Value = idContrato;
                param[1] = new SqlParameter("@subtotal", SqlDbType.Float);
                param[1].Value = subTotal;
                param[2] = new SqlParameter("@Descuento", SqlDbType.Float);
                param[2].Value = Descuento;
                param[3] = new SqlParameter("@LatitudSalida", SqlDbType.Float);
                param[3].Value = LatitudSalida;
                param[4] = new SqlParameter("@LongitudSalida", SqlDbType.Float);
                param[4].Value = LongitudSalida;
                param[5] = new SqlParameter("@LatitudLlegada", SqlDbType.Float);
                param[5].Value = LatitudLlegada;
                param[6] = new SqlParameter("@LongitudLlegada", SqlDbType.Float);
                param[6].Value = LongitudSalida;
                param[7] = new SqlParameter("@total", SqlDbType.Money);
                param[7].Value = Total;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizarDetalleContrato";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);
                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "Not ok";

                MessageBox.Show("Se Actualizo Perfectamente!");
                connect.Close();
            }
            catch (Exception)
            {

            }
        }



    }
}
