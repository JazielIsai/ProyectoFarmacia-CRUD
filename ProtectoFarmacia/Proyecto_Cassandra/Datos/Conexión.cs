using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Proyecto_Cassandra
{
    class Conexión
    {
        string StrCnx = "server=127.0.0.1; database=Farmacia; Uid=root; pwd=12345678;";
        public bool Conectado(string Query)
        {
            MySqlConnection ObjCnx = new MySqlConnection(StrCnx);
            try
            {
                ObjCnx.Open();

                MySqlCommand ObjCmd = new MySqlCommand(Query, ObjCnx);
                ObjCmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }


        public DataTable RegresaValores(string Query)
        {
            MySqlConnection ObjCnx = new MySqlConnection(StrCnx);
            DataSet DtSet = new DataSet();
            try
            {
                ObjCnx.Open();

                MySqlCommand ObjCmd = new MySqlCommand(Query,ObjCnx);
                ObjCmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(ObjCmd);
                da.Fill(DtSet);

                return DtSet.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        /* public static MySqlConnection conexionMSQL()
         {
             MySqlConnection conec = new MySqlConnection("server: ;database: ;Vid=root;pwd=;");
             conec.Open();
             return conec();
         }*/


    }
}
