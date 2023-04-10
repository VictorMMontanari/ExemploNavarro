namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();
            cliente.Nome = textBox1.Text;

            ContaCorrente contaCorrente = new ContaCorrente(cliente);
            contaCorrente.Depositar(Convert.ToDouble(textBox2.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}