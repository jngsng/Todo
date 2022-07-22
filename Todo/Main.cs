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

        // 메인 폼 로드시 실행되는 부분
        private void Main_Load(object sender, EventArgs e)
        {
            // Load Now data 
            today = DateTime.Now.ToString("yyy/M/d");
            this.Text = $" Todo // {today}";
        }

        // 달력 날짜 변경 시 실행되는 부분 >> 테스트 버튼으로 CSV로드 구현 후 이쪽으로 이동
        public void Date_Change(object sender, EventArgs e)

        {
            // load Excel File
            Title1.Text = "OK";
        }

        // 테스트용 버튼1
        private void button1_Click(object sender, EventArgs e)
        {
            // 폴더 생성
            string dir = Environment.CurrentDirectory + @"\date";
            
            DirectoryInfo di = new DirectoryInfo(dir);

            if(!di.Exists) Directory.CreateDirectory(dir);

            dir += @"\" + DateTime.Now.ToString("yyyy"+"MM");
            di = new DirectoryInfo(dir);

            if (!di.Exists) Directory.CreateDirectory(dir);

            // CSV 파일 가져오기

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

            // 파일 확장자가 이상하게 표시되어 변경 과정이 필요
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