using Farm_System.Cadastros;

namespace Farm_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cavalo cavalo = new Cavalo(tbNome.Text, tbRaca.Text);
            MessageBox.Show(cavalo.mensagem);

        }
    }
}