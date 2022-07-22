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
            string dir = Environment.CurrentDirectory + @"\date";
            
            // 폴더 생성
            DirectoryInfo di = new DirectoryInfo(dir);

            if(!di.Exists) Directory.CreateDirectory(dir);

            dir += @"\" + DateTime.Now.ToString("yyyy"+"mm");
            di = new DirectoryInfo(dir);
            if (!di.Exists) Directory.CreateDirectory(dir);

            // CSV 파일 가져오기
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