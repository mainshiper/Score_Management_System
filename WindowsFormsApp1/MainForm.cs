using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // 부모 폼에서 전달받은 값을 저장할 속성
        SqlCommand cmd;
        public string IDTextValue { get; set; }
        private void list_subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            String ID = IDTextValue; //로그인폼 아이디 값 가져오기 




            string connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\klmas\\Desktop\\WindowsFormsApp1\\DB\\data2.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE [Avarage] SET Apply_SCORE = (SELECT SUM(GRADE) FROM 이산수학 WHERE STUDENT_NUM = '" + ID + "') + 	(SELECT SUM(GRADE) FROM 논리회로및실습 WHERE STUDENT_NUM = '" + ID + "')+(SELECT SUM(GRADE) FROM 데이터구조 WHERE 	STUDENT_NUM = '" + ID + "')+(SELECT SUM(GRADE) FROM 정보보안개론 WHERE STUDENT_NUM = '" + ID + "')+(SELECT SUM(GRADE) FROM 데이터베이스 WHERE STUDENT_NUM = '" + ID + "')+(SELECT SUM(GRADE) FROM 웹프로그래밍 WHERE STUDENT_NUM = '" + ID + "')"; //신청학점 코
            cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE [Avarage] SET Average = ((SELECT SUM(RATING) FROM 이산수학 WHERE STUDENT_NUM = '" + ID + "') + (SELECT SUM(RATING) FROM 논리회로및실습 WHERE STUDENT_NUM = '" + ID + "') +(SELECT SUM(RATING) FROM 데이터구조 WHERE STUDENT_NUM = '" + ID + "') + (SELECT SUM(RATING) FROM 정보보안개론 WHERE STUDENT_NUM = '" + ID + "') + (SELECT SUM(RATING) FROM 데이터베이스 WHERE STUDENT_NUM = '" + ID + "') +(SELECT SUM(RATING) FROM 웹프로그래밍 WHERE STUDENT_NUM = '" + ID + "')) / 6";
            cmd.ExecuteNonQuery();
            // Setup ListView
            SetupListView();
            Setup2ListView();


            // Load data for each database connection
            LoadData(conn, "SELECT * FROM [웹프로그래밍] WHERE STUDENT_NUM = '" +ID + "' ");
            LoadData(conn, "SELECT * FROM [데이터구조] WHERE STUDENT_NUM = '" +ID + "'");
            LoadData(conn, "SELECT * FROM [이산수학] WHERE STUDENT_NUM = '" + ID + "'");
            LoadData(conn, "SELECT * FROM [정보보안개론] WHERE STUDENT_NUM = '" + ID + "'");
            LoadData(conn, "SELECT * FROM [데이터베이스] WHERE STUDENT_NUM = '" + ID + "'");
            LoadData(conn, "SELECT * FROM [논리회로및실습] WHERE STUDENT_NUM = '" + ID + "'");
            Load2Data(conn, "Select * FROM [Avarage]");
        }

        private void SetupListView()
        {
            list_subject.View = View.Details;
            list_subject.GridLines = true;
            int listWidth = list_subject.Width;
            list_subject.Columns.Add("연도", (int)(listWidth * 0.1));
            list_subject.Columns.Add("학기", (int)(listWidth * 0.1));
            list_subject.Columns.Add("과목명", (int)(listWidth * 0.1));
            list_subject.Columns.Add("학점", (int)(listWidth * 0.1));
            list_subject.Columns.Add("등급", (int)(listWidth * 0.1));
            list_subject.Columns.Add("평점", (int)(listWidth * 0.1));
        }
        private void Setup2ListView()
        {
            list_semester.View = View.Details;
            list_semester.GridLines = true;
            int listWidth = list_semester.Width;
            list_semester.Columns.Add("연도", (int)(listWidth * 0.1));
            list_semester.Columns.Add("학기", (int)(listWidth * 0.1));
            list_semester.Columns.Add("학년", (int)(listWidth * 0.1));
            list_semester.Columns.Add("신청학점", (int)(listWidth * 0.1));
            list_semester.Columns.Add("평점평균", (int)(listWidth * 0.1));
        }
        private void LoadData(SqlConnection conn, string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string data1 = reader.GetInt32(1).ToString();
                    string data2 = reader.GetInt32(2).ToString();
                    string data3 = reader.GetString(3);
                    string data4 = reader.GetInt32(4).ToString();
                    string data5 = reader.GetString(5);
                    string data6 = reader.GetDecimal(6).ToString();

                    ListViewItem item = new ListViewItem(data1);
                    item.SubItems.Add(data2);
                    item.SubItems.Add(data3);
                    item.SubItems.Add(data4);
                    item.SubItems.Add(data5);
                    item.SubItems.Add(data6);

                    list_subject.Items.Add(item);
                }
            }
        }
        private void Load2Data(SqlConnection conn, string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string data1 = reader.GetInt32(1).ToString();
                    string data2 = reader.GetInt32(2).ToString();
                    string data3 = reader.GetInt32(3).ToString();
                    string data4 = reader.GetInt32(4).ToString();
                    string data5 = reader.GetDecimal(5).ToString();

                    ListViewItem item = new ListViewItem(data1);
                    item.SubItems.Add(data2);
                    item.SubItems.Add(data3);
                    item.SubItems.Add(data4);
                    item.SubItems.Add(data5);


                    list_semester.Items.Add(item);
                }
            }
        }
    }
}