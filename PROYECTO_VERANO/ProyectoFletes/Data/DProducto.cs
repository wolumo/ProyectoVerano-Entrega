using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFletes.Data
{
    public class DProducto
    {
        public Conexion con;
        public string  logon;

        //public SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-JNDQ2L1\SQLEXPRESS;Initial Catalog=RyW;UID=" + "sa" + ";PWD=" + "1234");

       

        public DProducto(Conexion con , string logon)
        {
            this.con = con;
            this.logon = logon;

        }

        public DataTable CargarClientes(string logon)
        {

           SqlConnection connect = new SqlConnection(logon);
            Console.WriteLine("imprimimos cone" + logon); // de
            Console.WriteLine(connect);
            if (con.connect.State == ConnectionState.Open)
            {
                Console.WriteLine("si ta abierta");
            }
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarClientes";
            cmd.Connection = connect;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;



        }

        public DataTable CargarCategorias(string logon)
        {
            SqlConnection connect = new SqlConnection(logon);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarCategorias";
            cmd.Connection = connect;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public void InsertarProducto (string logon , string idCliente, int idCategoria , string Nombre , string Descripcion , SqlConnection connect)
        {
            string rpta = ""; 
            try
            {
                Console.WriteLine("hacemos parametros");
              
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@IdCliente" , SqlDbType.Char);
                param[0].Value = idCliente;
                param[1] = new SqlParameter("@IdCategoria", SqlDbType.Int);
                param[1].Value = idCategoria;
                param[2] = new SqlParameter("@Nombre" , SqlDbType.NVarChar);
                param[2].Value = Nombre;
                param[3] = new SqlParameter("@Descripcion", SqlDbType.NVarChar);
                param[3].Value = Descripcion;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarProducto";
                cmd.Connection = connect;
                Console.WriteLine("pasamos parametros");
                cmd.Parameters.AddRange(param);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "Not ok"; 

            }
            catch (Exception)
            {

            }
        }

    }
   
}
