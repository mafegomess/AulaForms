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

        private void BtnTroca_Click(object sender, EventArgs e)
        {
            string temp = txtValor1.Text;
            txtValor1.Text = txtValor2.Text;
            txtValor2.Text = temp;
            MessageBox.Show("Troca de valores conclu�da!", "Informa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
