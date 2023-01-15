using Farm_System.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Farm_System.Cadastros
{
    public class Cavalo
    {     
        Conexao conexao = new Conexao();
        NpgsqlCommand cmd = new NpgsqlCommand();
        public String mensagem = "";
       
        public Cavalo(String nome, string raca)
        {
            cmd.CommandText = "INSERT INTO CAVALOS(NOME, RACA) VALUES(@nome, @raca)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@raca", raca);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                //Teste

                this.mensagem = "Cadastrado com sucesso";

            } catch( SqlException e)
            {
                this.mensagem = "Erro ao conectar-se ao banco de dados";
            }

        }
        
    }
}
