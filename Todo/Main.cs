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
            
            DirectoryInfo di = new DirectoryInfo(dir);
            if(!di.Exists) Directory.CreateDirectory(dir);

            dir += @"\" + DateTime.Now.ToString("Y");
            if (!di.Exists) Directory.CreateDirectory(dir);

            //string dir = Environment.CurrentDirectory;
            label1.Text = dir;

            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            //dt = ds.Tables[0].Clone();

            //dataGridView1.DataSource = ds.Tables[0];

        }
    }
}