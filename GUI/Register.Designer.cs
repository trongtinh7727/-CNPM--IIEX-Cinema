namespace GUI
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_confirm_pwd = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_confirm_pwd = new System.Windows.Forms.TextBox();
            this.pl_gender = new System.Windows.Forms.Panel();
            this.rdo_female = new System.Windows.Forms.RadioButton();
            this.rdo_male = new System.Windows.Forms.RadioButton();
            this.lbl_register = new System.Windows.Forms.Label();
            this.cbb_city = new System.Windows.Forms.ComboBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_birth = new System.Windows.Forms.Label();
            this.dtp_birth = new System.Windows.Forms.DateTimePicker();
            this.btn_login = new System.Windows.Forms.Button();
            this.pl_gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(99, 102);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 16);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(99, 154);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(81, 16);
            this.lbl_fname.TabIndex = 2;
            this.lbl_fname.Text = "Họ và tên lót";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(96, 191);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(31, 16);
            this.lbl_lname.TabIndex = 3;
            this.lbl_lname.Text = "Tên";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(96, 232);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(61, 16);
            this.lbl_pwd.TabIndex = 4;
            this.lbl_pwd.Text = "Mật khẩu";
            // 
            // lbl_confirm_pwd
            // 
            this.lbl_confirm_pwd.AutoSize = true;
            this.lbl_confirm_pwd.Location = new System.Drawing.Point(96, 278);
            this.lbl_confirm_pwd.Name = "lbl_confirm_pwd";
            this.lbl_confirm_pwd.Size = new System.Drawing.Size(114, 16);
            this.lbl_confirm_pwd.TabIndex = 5;
            this.lbl_confirm_pwd.Text = "Nhập lại mật khẩu";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(376, 312);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(54, 16);
            this.lbl_gender.TabIndex = 6;
            this.lbl_gender.Text = "Giới tính";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(96, 364);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(65, 16);
            this.lbl_city.TabIndex = 7;
            this.lbl_city.Text = "Quê quán";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(227, 102);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(337, 22);
            this.txt_email.TabIndex = 9;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(227, 147);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(337, 22);
            this.txt_fname.TabIndex = 10;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(227, 191);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(337, 22);
            this.txt_lname.TabIndex = 11;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(227, 232);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(337, 22);
            this.txt_pwd.TabIndex = 12;
            // 
            // txt_confirm_pwd
            // 
            this.txt_confirm_pwd.Location = new System.Drawing.Point(229, 272);
            this.txt_confirm_pwd.Name = "txt_confirm_pwd";
            this.txt_confirm_pwd.Size = new System.Drawing.Size(335, 22);
            this.txt_confirm_pwd.TabIndex = 13;
            // 
            // pl_gender
            // 
            this.pl_gender.Controls.Add(this.rdo_female);
            this.pl_gender.Controls.Add(this.rdo_male);
            this.pl_gender.Location = new System.Drawing.Point(436, 304);
            this.pl_gender.Name = "pl_gender";
            this.pl_gender.Size = new System.Drawing.Size(128, 29);
            this.pl_gender.TabIndex = 14;
            // 
            // rdo_female
            // 
            this.rdo_female.AutoSize = true;
            this.rdo_female.Location = new System.Drawing.Point(78, 3);
            this.rdo_female.Name = "rdo_female";
            this.rdo_female.Size = new System.Drawing.Size(45, 20);
            this.rdo_female.TabIndex = 1;
            this.rdo_female.TabStop = true;
            this.rdo_female.Text = "Nữ";
            this.rdo_female.UseVisualStyleBackColor = true;
            // 
            // rdo_male
            // 
            this.rdo_male.AutoSize = true;
            this.rdo_male.Location = new System.Drawing.Point(3, 5);
            this.rdo_male.Name = "rdo_male";
            this.rdo_male.Size = new System.Drawing.Size(57, 20);
            this.rdo_male.TabIndex = 0;
            this.rdo_male.TabStop = true;
            this.rdo_male.Text = "Nam";
            this.rdo_male.UseVisualStyleBackColor = true;
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register.Location = new System.Drawing.Point(305, 38);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(124, 32);
            this.lbl_register.TabIndex = 15;
            this.lbl_register.Text = "Đăng ký";
            // 
            // cbb_city
            // 
            this.cbb_city.FormattingEnabled = true;
            this.cbb_city.Location = new System.Drawing.Point(229, 356);
            this.cbb_city.Name = "cbb_city";
            this.cbb_city.Size = new System.Drawing.Size(257, 24);
            this.cbb_city.TabIndex = 16;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(229, 395);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(119, 33);
            this.btn_register.TabIndex = 17;
            this.btn_register.Text = "Đăng ký";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(681, 405);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(107, 33);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "Xóa hết";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click_1);
            // 
            // lbl_birth
            // 
            this.lbl_birth.AutoSize = true;
            this.lbl_birth.Location = new System.Drawing.Point(99, 317);
            this.lbl_birth.Name = "lbl_birth";
            this.lbl_birth.Size = new System.Drawing.Size(67, 16);
            this.lbl_birth.TabIndex = 19;
            this.lbl_birth.Text = "Ngày sinh";
            // 
            // dtp_birth
            // 
            this.dtp_birth.CustomFormat = "dd/MM/yyyy";
            this.dtp_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_birth.Location = new System.Drawing.Point(227, 312);
            this.dtp_birth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_birth.Name = "dtp_birth";
            this.dtp_birth.Size = new System.Drawing.Size(110, 22);
            this.dtp_birth.TabIndex = 20;
            this.dtp_birth.Value = new System.DateTime(2023, 2, 8, 0, 0, 0, 0);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(379, 395);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(107, 33);
            this.btn_login.TabIndex = 21;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.dtp_birth);
            this.Controls.Add(this.lbl_birth);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.cbb_city);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.pl_gender);
            this.Controls.Add(this.txt_confirm_pwd);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_confirm_pwd);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.lbl_email);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.Register_Load);
            this.pl_gender.ResumeLayout(false);
            this.pl_gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_confirm_pwd;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_confirm_pwd;
        private System.Windows.Forms.Panel pl_gender;
        private System.Windows.Forms.RadioButton rdo_female;
        private System.Windows.Forms.RadioButton rdo_male;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.ComboBox cbb_city;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_birth;
        private System.Windows.Forms.DateTimePicker dtp_birth;
        private System.Windows.Forms.Button btn_login;
    }
}