using System.Data;
using System.IO;

namespace Todo
{
    public partial class Main : Form
    {
        string today = "";
        List<string> csvList = null;
        List<string> x = new List<string>();
        List<string> y = new List<string>();

        public Main()
        {
            InitializeComponent();
        }

        // ���� �� �ε�� ����Ǵ� �κ�
        private void Main_Load(object sender, EventArgs e)
        {
            // Load Now data 
            today = DateTime.Now.ToString("yyy/M/d");
            this.Text = $" Todo // {today}";
        }

        // �޷� ��¥ ���� �� ����Ǵ� �κ� >> �׽�Ʈ ��ư���� CSV�ε� ���� �� �������� �̵�
        public void Date_Change(object sender, EventArgs e)

        {
            // load Excel File
            Title1.Text = "OK";
        }

        // �׽�Ʈ�� ��ư1
        private void button1_Click(object sender, EventArgs e)
        {
            string dir = Environment.CurrentDirectory + @"\date";
            
            // ���� ����
            DirectoryInfo di = new DirectoryInfo(dir);

            if(!di.Exists) Directory.CreateDirectory(dir);

            dir += @"\" + DateTime.Now.ToString("yyyy"+"mm");
            di = new DirectoryInfo(dir);
            if (!di.Exists) Directory.CreateDirectory(dir);

            // CSV ���� ��������
            StreamReader file = new StreamReader("test.csv");
            DataTable table = new DataTable();
            table.Columns.Add("WaveLength");
            table.Columns.Add("Intensity");

            while(!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] data = line.Split(",");

                table.Rows.Add(data[0], data[1]);

                x.Add(data[1]);
                y.Add(data[2]);

            }

            dataGridView1.DataSource = table;

        }

        public void GetCSVData(List<string> csvList, string result)
        {
           
        }

        private void Read_Click(object sender, EventArgs e)
        {

        }

    }
}