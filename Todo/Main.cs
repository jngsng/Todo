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

        // ���� �� �ε�
        private void Main_Load(object sender, EventArgs e)
        {
            // Load Now data 
            today = DateTime.Now.ToString("yyy/M/d");
            this.Text = $" Todo // {today}";

            Create_File1(sender, e);
            Create_File2(sender, e);
            Create_File3(sender, e);
            Create_File4(sender, e);
        }

        // �޷� ��¥ ���� �� �̺�Ʈ
        public void Date_Change(object sender, EventArgs e)

        {
            Create_File1(sender, e);
            Create_File2(sender, e);
            Create_File3(sender, e);
            Create_File4(sender, e);
        }

        // �׽�Ʈ�� ��ư
        private void button1_Click(object sender, EventArgs e)
        {

        }

        // ���� ���� �Լ�
        // >> txt���� ���� �ȸ��� ��� ���� �߻� Ȯ�� �ʿ�
        public void Create_File1(object sender, EventArgs e)
        {
            // ���� üũ �� ����
            string dir = Environment.CurrentDirectory + @"\date";

            DirectoryInfo di = new DirectoryInfo(dir);

            if (!di.Exists) Directory.CreateDirectory(dir);

            dir += @"\" + DateTime.Now.ToString("yyyy" + "MM");
            di = new DirectoryInfo(dir);

            if (!di.Exists) Directory.CreateDirectory(dir);

            // DateTimePicker���� ����� ������ ��������
            DateTime dt_val = dateTimePicker1.Value;
            string dt = dt_val.ToString("yyyy" + "MM" + "dd");
            string dt_folder = dt_val.ToString("yyyy" + "MM");
            string dt_file = dt_val.ToString("yyyy" + "MM" + "dd" + ".txt");
            string path = @"date\" + dt_folder + "\\" + dt_file;

            // ���� Ȯ����  ���� ����
            var cvt_path = Path.ChangeExtension(path, ".txt");

            // ���� üũ �� ����
            if (!File.Exists(cvt_path))
            {
                StreamWriter file = File.CreateText(cvt_path);
            }

            // txt ���� ��������

            StreamReader files = new StreamReader(File.OpenRead(cvt_path), Encoding.Default);
            DataTable table = new DataTable();
            table.Columns.Add("List");
            table.Columns.Add("Check");

            while (!files.EndOfStream)
            {
                string line = files.ReadLine();
                string[] data = line.Split(",");

                table.Rows.Add(data[0], data[1]);

                list.Add(data[0]);
                check.Add(data[1]);

            }

            dataGridView1.DataSource = table;
        }

        public void Create_File2(object sender, EventArgs e)
        {
            // ���� üũ �� ����
            string dir = Environment.CurrentDirectory + @"\dolist";

            DirectoryInfo di = new DirectoryInfo(dir);

            if (!di.Exists) Directory.CreateDirectory(dir);

            dir += @"\" + DateTime.Now.ToString("yyyy" + "MM");
            di = new DirectoryInfo(dir);

            if (!di.Exists) Directory.CreateDirectory(dir);

            // DateTimePicker���� ����� ������ ��������
            DateTime dt_val = dateTimePicker1.Value;
            string dt = dt_val.ToString("yyyy" + "MM" + "dd");
            string dt_folder = dt_val.ToString("yyyy" + "MM");
            string dt_file = dt_val.ToString("yyyy" + "MM" + "dd" + ".txt");
            string path = @"dolist\" + dt_folder + "\\" + dt_file;

            // ���� Ȯ����  ���� ����
            var cvt_path = Path.ChangeExtension(path, ".txt");

            // ���� üũ �� ����
            if (!File.Exists(cvt_path))
            {
                StreamWriter file = File.CreateText(cvt_path);
            }

            // txt ���� ��������

            StreamReader files = new StreamReader(File.OpenRead(cvt_path), Encoding.Default);
            DataTable table = new DataTable();
            table.Columns.Add("List");
            table.Columns.Add("Check");

            while (!files.EndOfStream)
            {
                string line = files.ReadLine();
                string[] data = line.Split(",");

                table.Rows.Add(data[0], data[1]);

                list.Add(data[0]);
                check.Add(data[1]);

            }

            dataGridView2.DataSource = table;
        }

        public void Create_File3(object sender, EventArgs e)
        {
            // ���� üũ �� ����
            string dir = Environment.CurrentDirectory + @"\paper";

            DirectoryInfo di = new DirectoryInfo(dir);

            if (!di.Exists) Directory.CreateDirectory(dir);

            dir += @"\" + DateTime.Now.ToString("yyyy" + "MM");
            di = new DirectoryInfo(dir);

            if (!di.Exists) Directory.CreateDirectory(dir);

            // DateTimePicker���� ����� ������ ��������
            DateTime dt_val = dateTimePicker1.Value;
            string dt = dt_val.ToString("yyyy" + "MM" + "dd");
            string dt_folder = dt_val.ToString("yyyy" + "MM");
            string dt_file = dt_val.ToString("yyyy" + "MM" + "dd" + ".txt");
            string path = @"paper\" + dt_folder + "\\" + dt_file;

            // ���� Ȯ����  ���� ����
            var cvt_path = Path.ChangeExtension(path, ".txt");

            // ���� üũ �� ����
            if (!File.Exists(cvt_path))
            {
                StreamWriter file = File.CreateText(cvt_path);
            }

            // txt ���� ��������

            StreamReader files = new StreamReader(File.OpenRead(cvt_path), Encoding.Default);
            DataTable table = new DataTable();
            table.Columns.Add("List");
            table.Columns.Add("Check");

            while (!files.EndOfStream)
            {
                string line = files.ReadLine();
                string[] data = line.Split(",");

                table.Rows.Add(data[0], data[1]);

                list.Add(data[0]);
                check.Add(data[1]);

            }

            dataGridView3.DataSource = table;
        }

        public void Create_File4(object sender, EventArgs e)
        {
            // ���� üũ �� ����
            string dir = Environment.CurrentDirectory + @"\buy";

            DirectoryInfo di = new DirectoryInfo(dir);

            if (!di.Exists) Directory.CreateDirectory(dir);

            dir += @"\" + DateTime.Now.ToString("yyyy" + "MM");
            di = new DirectoryInfo(dir);

            if (!di.Exists) Directory.CreateDirectory(dir);

            // DateTimePicker���� ����� ������ ��������
            DateTime dt_val = dateTimePicker1.Value;
            string dt = dt_val.ToString("yyyy" + "MM" + "dd");
            string dt_folder = dt_val.ToString("yyyy" + "MM");
            string dt_file = dt_val.ToString("yyyy" + "MM" + "dd" + ".txt");
            string path = @"buy\" + dt_folder + "\\" + dt_file;

            // ���� Ȯ����  ���� ����
            var cvt_path = Path.ChangeExtension(path, ".txt");

            // ���� üũ �� ����
            if (!File.Exists(cvt_path))
            {
                StreamWriter file = File.CreateText(cvt_path);
            }

            // txt ���� ��������

            StreamReader files = new StreamReader(File.OpenRead(cvt_path), Encoding.Default);
            DataTable table = new DataTable();
            table.Columns.Add("List");
            table.Columns.Add("Check");

            while (!files.EndOfStream)
            {
                string line = files.ReadLine();
                string[] data = line.Split(",");

                table.Rows.Add(data[0], data[1]);

                list.Add(data[0]);
                check.Add(data[1]);

            }

            dataGridView4.DataSource = table;
        }

        public void Save(string filename, DataGridView dgv)
        {
            string seperator = ";";
            FileStream fs = new FileStream(filename,System.IO)
        }
    }
}