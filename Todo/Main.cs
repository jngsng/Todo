using System.Data;

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
            // Load Now data 
            today = DateTime.Now.ToString("yyy/M/d");
            this.Text = $" Todo // {today}";
        }

        public void Date_Change(object sender, EventArgs e)
        {
            // load Excel File
            Title1.Text = "OK";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dir = Environment.CurrentDirectory + @"\date";
            dir = new DirectoryInfo(dir);

            //string dir = Environment.CurrentDirectory;
            //Title1.Text = dir;

            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            //dt = ds.Tables[0].Clone();

            //dataGridView1.DataSource = ds.Tables[0];

        }
    }
}