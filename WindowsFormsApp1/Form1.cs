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

    
    public partial class loginForm : Form
	{
		public loginForm()
		{
			InitializeComponent();
		}
        

        private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_password_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void bt_login_click_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\klmas\\Desktop\\데이터베이스 (2)\\Data5.mdf\";Integrated Security=True;Connect Timeout=30"); //나의 컴 데이터 베이스 
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserINFO where USERNAME='"+ID_TXT.Text+"' and PASSWORD='"+PASSWORD_TXT.Text+"'",con); //선택된 객체를 세어라 (userinfo 테이블에서 )
                //아이디 와 패스워드 가 만족하면 1을 반환 아니면 0반환 
                DataTable newTable = new DataTable(); //데이터테이블 생성
                sda.Fill(newTable); //데이터 테이블을 뉴테이블에 덮에 씌우기
                
                if (newTable.Rows[0][0].ToString() == "1"){
                //로그인 성공인 경우
                this.Hide(); //로그인 폼 숨기기 
                MainForm mainForm1 = new MainForm(); //학생용 폼 생성
                mainForm1.IDTextValue = ID_TXT.Text; //학생용 폼으로 id값 전달
                mainForm1.ShowDialog(); //띄우기
                 }
                 else
                 {   //로그인 실패시
                     MessageBox.Show("아이디와 비밀번호를 확인해주세요");
                 }
                
                

            
        }

         public void ID_TXT_TextChanged(object sender, EventArgs e)
        {

          
        }
    }
}
