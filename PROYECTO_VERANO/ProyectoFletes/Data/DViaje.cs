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
    
    public class DViaje
    {
        public string logon;

        public DViaje(string logon)
        {
            this.logon = logon;
        }

        public DataTable CargarPilotosLibres(int IdSucursal)
        {
            SqlConnection connect = new SqlConnection(logon);
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idSucursal", SqlDbType.Int);
            param[0].Value = IdSucursal;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CargarPilotosLibres";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            if(dt == null)
            {
                Console.WriteLine("Ya no se que hacer");
            }
            return dt;
        }

        public DataTable CargarProductos(int idCliente)
        {
            SqlConnection connect = new SqlConnection(logon);
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idCliente", SqlDbType.Int);
            param[0].Value = idCliente;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarProductos";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            return dt;

        }
        public DataTable CargarCamionesLibres(int IdSucursal)
        {
            SqlConnection connect = new SqlConnection(logon);
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idSucursal" , SqlDbType.Int);
            param[0].Value = IdSucursal;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CargarCamionesLibres";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            return dt;
        }
        public void InsertarViaje(int idContrato,int idSucursal,int idPiloto , int IdCamion)
        {
            string rpta = "";
            try
            {
                SqlConnection connect = new SqlConnection(logon);
                connect.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@idContrato",SqlDbType.Int);
                param[0].Value = idContrato;
                param[1] = new SqlParameter("@idSucursal", SqlDbType.Int);
                param[1].Value = idSucursal;
                param[2] = new SqlParameter("@idPiloto" , SqlDbType.Int);
                param[2].Value = idPiloto;
                param[3] = new SqlParameter("@IdCamion" , SqlDbType.Int);
                param[3].Value = IdCamion;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertarViaje";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "Not ok";
                connect.Close();

                MessageBox.Show("Se ha insertado");
            }
            catch (Exception)
            {

            }

        }

        public void ListarViajesEnCurso (DataGridView gridView)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection connect = new SqlConnection(logon);

            connect.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarViajesEnCurso";
            cmd.Connection = connect;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

        }

        public void ListarViajesTerminados (DataGridView gridView)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection connect = new SqlConnection(logon);

            connect.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarViajesTerminados";
            cmd.Connection = connect;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

        }
    }
            
}
