using BLL;

namespace ListaDeNotas
{
    public partial class frmListaNotas : Form
    {
        public Repositorio Repositorio { get; set; } = new Repositorio();
        public frmListaNotas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            aluno.Ra = txtRA.Text;
            aluno.Nome = txtNome.Text;
            aluno.P1 = float.Parse(txtP1.Text);
            aluno.P2 = float.Parse(txtP2.Text);

            Repositorio.Incluir(aluno);
            MessageBox.Show("Aluno incluido com sucesso");

            txtRA.Text = "";
            txtNome.Text = "";
            txtP1.Text = ""; 
            txtP2.Text = ""; 

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listAlunos.Items.Clear();   
            foreach (var al in Repositorio.Alunos)
            {
                listAlunos.Items.Add(al);

            }
        }
    }
}