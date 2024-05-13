using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public string IDTextValue { get; set; }
        private void list_subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            String ID = IDTextValue;
            
            string connectionString1 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\klmas\\Documents\\data6.mdf;Integrated Security=True;Connect Timeout=30";
            string connectionString2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\klmas\\Desktop\\새 폴더 (2)\\확률과 통계.mdf\";Integrated Security=True;Connect Timeout=30";
            
            using (SqlConnection conn1 = new SqlConnection(connectionString1))
            using (SqlConnection conn2 = new SqlConnection(connectionString2))
                
            {
                conn1.Open();
                conn2.Open();
               
                // Setup ListView
                SetupListView();

                

                // Load data for each database connection
                LoadData(conn1, "SELECT * FROM [Table] WHERE STUDENT_NUM = '" +ID + "' ");
                LoadData(conn2, "SELECT * FROM [Table] WHERE STUDENT_NUM = '" +ID + "'");
            }
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
                    string data6 = reader.GetString(6);

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
    }
}