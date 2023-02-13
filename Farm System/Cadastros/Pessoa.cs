using Farm_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Npgsql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_System.Cadastros
{
    class Pessoa
    {
        public int Id { get; set; }
        public String  Nome { get; set; }            

        public DateTime DataCadastro { get; set; }

        public string Email { get; set; }
      

        
    }   
}
