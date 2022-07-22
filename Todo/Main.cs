using System.Data;
using System.IO;
using System.Text;

namespace Todo
{
    public partial class Main : Form
    {
        string today = "";

        List<string> list = new List<string>();
        List<string> check = new List<string>();

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
            // ���� ����
            string dir = Environment.CurrentDirectory + @"\date";
            
            DirectoryInfo di = new DirectoryInfo(dir);

            if(!di.Exists) Directory.CreateDirectory(dir);

            dir += @"\" + DateTime.Now.ToString("yyyy"+"MM");
            di = new DirectoryInfo(dir);

            if (!di.Exists) Directory.CreateDirectory(dir);

            // CSV ���� ��������

            StreamReader file = new StreamReader(File.OpenRead("test.txt"),Encoding.Default);
            DataTable table = new DataTable();
            table.Columns.Add("List");
            table.Columns.Add("Check");

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] data = line.Split(",");

                table.Rows.Add(data[0], data[1]);

                list.Add(data[0]);
                check.Add(data[1]);

            }

            dataGridView1.DataSource = table;

        }

        private void Create_File (object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy" + "MM");
            string memo = DateTime.Now.ToString("yyyy" + "MM" + "dd"+".txt");
            string path = @"date\" + date + "\\" + memo;

            // ���� Ȯ���ڰ� �̻��ϰ� ǥ�õǾ� ���� ������ �ʿ�
            var cvt_path = Path.ChangeExtension(path, ".txt");

            if (!File.Exists(cvt_path))
            {
                MessageBox.Show(cvt_path);
                StreamWriter file = File.CreateText(cvt_path);
            }
            else
            {
                MessageBox.Show("else");
            }
        }

    }
}