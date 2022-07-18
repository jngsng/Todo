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
            today = DateTime.Now.ToString("yyy/M/d");
            this.Text = $" Todo // {today}";
        }

    }
}