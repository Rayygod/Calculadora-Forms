namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // soma mais +1 segundo na progress bar
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                // faz com que o timer pare de funcionar para ele parar de rodar
                timer1.Enabled = false;
                // Ele esconde o formulario
                this.Hide();
                FrmWindow formswindow = new FrmWindow();
                formswindow.ShowDialog();

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
