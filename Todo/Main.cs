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

            Create_File(sender, e);
        }

        // 달력 날짜 변경 시 실행되는 부분 >> 테스트 버튼으로 CSV로드 구현 후 이쪽으로 이동
        public void Date_Change(object sender, EventArgs e)

        {
            Create_File(sender, e);
        }

        // 테스트용 버튼1
        private void button1_Click(object sender, EventArgs e)
        {

        }


        // 파일 생성 함수
        public void Create_File(object sender, EventArgs e)
        {
            // 폴더 체크 및 생성
            string dir = Environment.CurrentDirectory + @"\date";

            DirectoryInfo di = new DirectoryInfo(dir);

            if (!di.Exists) Directory.CreateDirectory(dir);

            dir += @"\" + DateTime.Now.ToString("yyyy" + "MM");
            di = new DirectoryInfo(dir);

            if (!di.Exists) Directory.CreateDirectory(dir);

            // DateTimePicker에서 년월일 데이터 가져오기
            DateTime dt_val = dateTimePicker1.Value;
            string dt = dt_val.ToString("yyyy" + "MM" + "dd");
            string dt_folder = dt_val.ToString("yyyy" + "MM");
            string dt_file = dt_val.ToString("yyyy" + "MM" + "dd" + ".txt");
            string path = @"date\" + dt_folder + "\\" + dt_file;

            // 파일 확장자  변경 과정
            var cvt_path = Path.ChangeExtension(path, ".txt");   

            // 파일 체크 및 생성
            if (!File.Exists(cvt_path))
            {
                StreamWriter file = File.CreateText(cvt_path);
            }

            // CSV 파일 가져오기

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

    }
}