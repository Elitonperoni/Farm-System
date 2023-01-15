using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_System.Model
{
    public class Conexao
    {
        NpgsqlConnection con = new NpgsqlConnection();
        public Conexao() 
        {
            con.ConnectionString = "server=localhost;port=5432;user id=postgres;password=123456;database=farmsystem";
        }    

        public NpgsqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed) {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }           
        }
    }
}
