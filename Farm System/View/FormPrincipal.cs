using Farm_System.View;
using Farm_System.View.Padrões;

namespace Farm_System
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDePessoas p = new CadastroDePessoas(this);            
            p.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FormImagemInicial f = new FormImagemInicial();
            f.MdiParent = this;
            f.Show();
        }
    }
}