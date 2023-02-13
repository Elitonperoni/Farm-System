using Farm_System;
using Farm_System.View;

namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string pasta = @"D:\C#\";
            string arquivo = "teste.txt";

            //bool res = File.Exists(pasta + arquivo);
            //label1.Text = res.ToString();
            //File.Delete(pasta + arquivo);

           /* if (!File.Exists(pasta + arquivo))
            {
                File.Create(pasta + arquivo).Close();
                label1.Text = "Criado";
            }
            else
            {
                label1.Text = "Já existe";
            }       */ 

        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excluir p = new Excluir();     
            p.MdiParent= this;               
            p.Show();
        }

        private void cavalosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDePessoasOficial p = new CadastroDePessoasOficial();
            p.MdiParent = this;            
            p.Show();
        }
    }
}