using Farm_System.View;

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
    }
}