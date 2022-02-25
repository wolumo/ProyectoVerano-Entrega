using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFletes.Data
{
    public class DataPiloto
    {
        public Conexion con;
        public DataPiloto(Conexion con)
        {
            this.con = con;
        }
        public void agregar_Piloto(String Cedula, String pn, String sn, String pa, String sa, String ant, String licencia)
        {


            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Cedula", SqlDbType.Char);
            param[0].Value = Cedula;
            param[1] = new SqlParameter("@Pn", SqlDbType.NVarChar);
            param[1].Value = pn;
            param[2] = new SqlParameter("@sn", SqlDbType.NVarChar);
            param[2].Value = sn;
            param[3] = new SqlParameter("@Pa", SqlDbType.NVarChar);
            param[3].Value = pa;
            param[4] = new SqlParameter("@Sa", SqlDbType.NVarChar);
            param[4].Value = sa;
            param[5] = new SqlParameter("@ant", SqlDbType.Date);
            param[5].Value = ant;
            param[6] = new SqlParameter("@Licencia", SqlDbType.Char);
            param[6].Value = licencia;



            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AgregarPiloto";
            cmd.Connection = con.connect;
            cmd.Parameters.AddRange(param);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);



        }
    }
}
