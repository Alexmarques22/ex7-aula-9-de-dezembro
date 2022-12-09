namespace ex9dezembro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mensagem1.Visible = false;
        }

        private void mensagem1_Click(object sender, EventArgs e)
        {
            
          
        }

        private void botao_Click(object sender, EventArgs e)
        {
            mensagem1.Visible = true;


        mensagem1.Text = "ola mundo ";
            


        }
    }
}