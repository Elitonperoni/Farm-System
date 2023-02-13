using Farm_System.Cadastros;
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
    public partial class CadastroDePessoas : Form
    {
        public CadastroDePessoas()
        {
            InitializeComponent();
            
            ListViewItem item1 = new ListViewItem("Ciclano");
            item1.SubItems.Add("1234");
            item1.SubItems.Add("Email@gmail.com");

            ListViewItem item2 = new ListViewItem("Thais");
            item2.SubItems.Add("5345345345");
            item2.SubItems.Add("starlink@gmail.com");

            ListViewItem item3 = new ListViewItem("Maria");
            item3.SubItems.Add("423423423");
            item3.SubItems.Add("genesis@global.com");

            ListViewItem item4 = new ListViewItem(new string[] { "Maria", "1234", "empresa@enterprise.com"});

            listaDetalhes.Items.Add(item1);
            listaDetalhes.Items.Add(item2);
            listaDetalhes.Items.Add(item3);
            listaDetalhes.Items.Add(item4);
        }

        private void button1_Click(object sender, EventArgs e)
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
        }  

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listaDetalhes.Items.Remove(listaDetalhes.SelectedItems[0]);
        }
    }
}
