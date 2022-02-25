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
    public class Conexion
    {
        public  SqlConnection connect = new SqlConnection();
        public Conexion(String user, String pass)
        {
            try
            {

                connect = new SqlConnection(@"Data Source=DESKTOP-JNDQ2L1;Initial Catalog=RyW;UID=" + user + ";PWD=" + pass);
                connect.Open();
            }
            catch (Exception)
            {


            }
        }

        public void AbrirConexion()
        {
            connect.Close();
            connect.Open();
        }
        //MAE AQUI PUSE LAS ONDAS DE SUCURSAL
        //PARA CARGAR DEPARTAMENTOS 
        public DataTable CargarComa(int index)
        {

            string query = "select NombreComa from Comarca where Id_Muni = " + index;
            SqlCommand cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = connect;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public DataTable CargarMuni(int index)
        {

            string query = "select NombreMuni from Municipio where id_Dep = " + index;
            SqlCommand cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = connect;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public DataTable CmbDep()
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ViewDepto";
            cmd.Connection = connect;
            

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;

        }

        public void InsertarSucursal (string Direccion , DateTime Antiguedad, string Tel,float Latitud , float Longitud , int idDept)
        {
            string rpta = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@Direccion", SqlDbType.NVarChar);
                param[0].Value = Direccion;
                param[1] = new SqlParameter("@Antiguedad", SqlDbType.Date);
                param[1].Value = Antiguedad;
                param[2] = new SqlParameter("@Tel", SqlDbType.Char);
                param[2].Value = Tel;
                param[3] = new SqlParameter("@Latitud", SqlDbType.Float);
                param[3].Value = Latitud;
                param[4] = new SqlParameter("@Longitud", SqlDbType.Float);
                param[4].Value = Longitud;
                param[5] = new SqlParameter("@idDept", SqlDbType.Int);
                param[5].Value = idDept;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarSucursal";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "Not ok";
                MessageBox.Show("Insertado Correctamente!");
            }
            catch (Exception)
            {

            }
        }

    }
}
