using Farm_System.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_System.Cadastros
{
    class Fornecedor : Pessoa
    {
        public String CNPJ { get; set; }

        Conexao conexao = new Conexao();
        NpgsqlCommand cmd = new NpgsqlCommand();       

        public void CadastrarFornecedor(Pessoa pessoa)
        {
            cmd.CommandText = "INSERT INTO PESSFOR(NOME, CNPJ) VALUES(@Nome, @CNPJ)";

            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@CNPJ", CNPJ);

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
