namespace Todo
{
    public partial class Main : Form
    {
        string today = "";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

                private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = today;
        }
    }
}