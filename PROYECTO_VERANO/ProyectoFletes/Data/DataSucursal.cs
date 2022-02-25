using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFletes.Data
{
    public class DataSucursal
    {
        Conexion con;
        public DataSucursal(Conexion con)
        {
            this.con = con;
        }

        public DataTable CargarComa(int index)
        {

            string query = "select NombreComa from Comarca where Id_Muni = " + index;
            SqlCommand cmd = new SqlCommand(query);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = con.connect;

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
            cmd.Connection = con.connect;

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
            cmd.CommandText = "CmbDep";
            cmd.Connection = con.connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;

        }
        public void agregar_Sucursal(String Direccion, int idC, String Anti, String tel)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@direccion", SqlDbType.NVarChar);
            param[0].Value = Direccion;
            param[1] = new SqlParameter("@idComarca", SqlDbType.Int);
            param[1].Value = idC;
            param[2] = new SqlParameter("@antiguedad", SqlDbType.Date);
            param[2].Value = Anti;
            param[3] = new SqlParameter("@tel", SqlDbType.Char);
            param[3].Value = tel;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AgregarSucursal";
            cmd.Connection = con.connect;
            cmd.Parameters.AddRange(param);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);



        }
    }
}
