using Farm_System.Model;
using Farm_System.View;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_System.Controller
{
    class Cliente : Pessoa
    {
        public String CPF { get; set; }

        Conexao conexao = new Conexao();
        NpgsqlCommand cmd = new NpgsqlCommand();        

        public Cliente(String cpf)
        {
            CPF = cpf;
        }

        public void CadastrarCliente(Cliente cliente)
        {           
            cmd.CommandText = "INSERT INTO PESSCLI(NOME, CPF) VALUES(@Nome, @CPF)";

            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@CPF", CPF);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                MessageBox.Show("Cadastrado com sucesso");

            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao conectar-se ao banco de dados");
            }
        }
    }
}
