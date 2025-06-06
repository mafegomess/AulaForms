namespace TrocaValores
{
    public partial class FrmTrocaValores : Form
    {
        public FrmTrocaValores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo!!!");
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnTroca_Click(object sender, EventArgs e)
        {
            string temp = txtValor1.Text;
            txtValor1.Text = txtValor2.Text;
            txtValor2.Text = temp;
            MessageBox.Show("Troca de valores concluída!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
