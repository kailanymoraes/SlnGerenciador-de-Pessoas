using PrjHelloWorld.Models;

namespace GerencadorDePessoas
{
    public partial class gerenciadorDePessoas : Form
    {
        public gerenciadorDePessoas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pessoa pessoinha = new Pessoa();
        }

        private void lblCriarPessoa_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarPessoa_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int Idade = Convert.ToInt32(txtIdade.Text);

            Pessoa p = new Pessoa(nome, Idade);
        }
    }
}