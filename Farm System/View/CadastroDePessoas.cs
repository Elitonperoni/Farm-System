using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_System.View
{
    public partial class CadastroDePessoas : View.FormPadrao
    {
        public CadastroDePessoas(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            this.WindowState = FormWindowState.Maximized;
        }

        /*public override void ActSalvar()
        {
            if (cbCliente.Checked)
            {
                Cliente cliente = new Cliente(tbCpfCnpj.Text);
                cliente.Nome = tbNome.Text;
                cliente.CPF = tbCpfCnpj.Text;
                cliente.CadastrarCliente(cliente);
            }
            if (cbFornecedor.Checked)
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Nome = tbNome.Text;
                fornecedor.CNPJ = tbCpfCnpj.Text;
                fornecedor.CadastrarFornecedor(fornecedor);
            }
        }*/
    }
}
