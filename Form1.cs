namespace Forms1
{
    public partial class Form1 : Form
    {
        int clicks = 0;
        string[] frases =
        {
            "Tem Certeza?",
            "Are you sure about that??",
            "¿estas cierto deso?",
            "rnон уверен?? "
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aceitar_Click(object sender, EventArgs e)
        {
            clicks++;

            txtMensagem.Text = frases[clicks - 1];
            btnAceitar.Size = new System.Drawing.Size((150 - clicks * 20), (100 - clicks * 20));
            if (clicks == 1)
            {
                BackColor = Color.Red;
               
            }

            //txtMensagem.Text = frases[0];
            //if (clicks == 2)
            //    txtMensagem.Text = frases[1];
            //if (clicks == 3)
            //    txtMensagem.Text = frases[2];

            if (clicks > 3)
                clicks = 0;

        }

        private void Rejeitar(object sender, EventArgs e)
        {

        }

        private void Rejeitar_Click(object sender, EventArgs e)
        {
            txtMensagem.Text = "Obrigado!";
            clicks = 0;
        }
    }
}