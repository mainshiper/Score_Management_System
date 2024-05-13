
namespace WindowsFormsApp1
{
	partial class loginForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ID_TXT = new System.Windows.Forms.TextBox();
            this.PASSWORD_TXT = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.ptbox_background = new System.Windows.Forms.Panel();
            this.ptbox_logo = new System.Windows.Forms.PictureBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.ptbox_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(40, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 1);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(40, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 1);
            this.panel2.TabIndex = 1;
            // 
            // ID_TXT
            // 
            this.ID_TXT.BackColor = System.Drawing.SystemColors.Control;
            this.ID_TXT.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_TXT.Location = new System.Drawing.Point(40, 203);
            this.ID_TXT.Name = "ID_TXT";
            this.ID_TXT.Size = new System.Drawing.Size(200, 26);
            this.ID_TXT.TabIndex = 2;
            this.ID_TXT.TextChanged += new System.EventHandler(this.ID_TXT_TextChanged);
            // 
            // PASSWORD_TXT
            // 
            this.PASSWORD_TXT.BackColor = System.Drawing.SystemColors.Control;
            this.PASSWORD_TXT.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD_TXT.Location = new System.Drawing.Point(40, 289);
            this.PASSWORD_TXT.Name = "PASSWORD_TXT";
            this.PASSWORD_TXT.PasswordChar = '*';
            this.PASSWORD_TXT.Size = new System.Drawing.Size(200, 26);
            this.PASSWORD_TXT.TabIndex = 4;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_password.Location = new System.Drawing.Point(36, 267);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(99, 19);
            this.lb_password.TabIndex = 6;
            this.lb_password.Text = "Password";
            this.lb_password.Click += new System.EventHandler(this.lb_password_Click);
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_login.FlatAppearance.BorderSize = 0;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(102, 366);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 35);
            this.bt_login.TabIndex = 7;
            this.bt_login.Text = "login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_click_Click);
            // 
            // ptbox_background
            // 
            this.ptbox_background.Controls.Add(this.ptbox_logo);
            this.ptbox_background.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbox_background.Location = new System.Drawing.Point(0, 0);
            this.ptbox_background.Name = "ptbox_background";
            this.ptbox_background.Size = new System.Drawing.Size(276, 175);
            this.ptbox_background.TabIndex = 8;
            this.ptbox_background.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ptbox_logo
            // 
            this.ptbox_logo.BackColor = System.Drawing.Color.Transparent;
            this.ptbox_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbox_logo.BackgroundImage")));
            this.ptbox_logo.ErrorImage = null;
            this.ptbox_logo.InitialImage = null;
            this.ptbox_logo.Location = new System.Drawing.Point(12, 0);
            this.ptbox_logo.Name = "ptbox_logo";
            this.ptbox_logo.Size = new System.Drawing.Size(252, 175);
            this.ptbox_logo.TabIndex = 1;
            this.ptbox_logo.TabStop = false;
            this.ptbox_logo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_id.Location = new System.Drawing.Point(36, 180);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(25, 19);
            this.lb_id.TabIndex = 9;
            this.lb_id.Text = "ID";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 436);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.ptbox_background);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.PASSWORD_TXT);
            this.Controls.Add(this.ID_TXT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ptbox_background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox ID_TXT;
		private System.Windows.Forms.TextBox PASSWORD_TXT;
		private System.Windows.Forms.Label lb_password;
		private System.Windows.Forms.Button bt_login;
		private System.Windows.Forms.Panel ptbox_background;
		private System.Windows.Forms.PictureBox ptbox_logo;
        private System.Windows.Forms.Label lb_id;
    }
}

