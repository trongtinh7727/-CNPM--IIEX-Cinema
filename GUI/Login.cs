using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {         

            if(IsValidEmail(txt_email.Text) == false)
            {
                MessageBox.Show("Email không hợp lệ");
                txt_email.Focus();
                lbl_email.ForeColor = Color.Red;
            }
            else
            if (BUS.UserBUS.Instance.Login(txt_email.Text, txt_pwd.Text))
            {
                frm_Report frm_Report = new frm_Report();
                frm_Report.ShowDialog();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }

        }

        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();
            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Visible = false;
            register.ShowDialog();
        }
    }
}
