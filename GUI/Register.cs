using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            var gender = pl_gender.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            bool check = false;
            if (IsValidEmail(txt_email.Text) == false)
            {
                lbl_email.ForeColor = Color.Red;
                txt_email.Focus();
            }
            else if (IsValidPassword(txt_pwd.Text) == false)
            {
                lbl_pwd.ForeColor = Color.Red;
                txt_pwd.Focus();
            }
            else if(IsValidName(txt_fname.Text) == false)
            {
                MessageBox.Show("Invalid FirstName");
                txt_fname.Focus();
            }
            else if (IsValidName(txt_lname.Text) == false)
            {
                MessageBox.Show("Invalid LastName");
                txt_lname.Focus();
            }
            else if (txt_fname.Text.Length == 0)
            {
                MessageBox.Show("Please enter your first name");
                txt_fname.Focus();
            }
            else if (txt_lname.Text.Length == 0)
            {
                MessageBox.Show("Please enter your last name");
                txt_lname.Focus();
            }
            else if (txt_email.Text.Length == 0)
            {
                MessageBox.Show("Please enter your email");
                txt_email.Focus();
            }
            else if (gender == null)
            {
                MessageBox.Show("Please choose your gender");
                gender.Focus();
            }
            else if (cbb_city.SelectedItem == null)
            {
                MessageBox.Show("Please choose your city");
                cbb_city.Focus();
            }
            else if (dtp_birth.Value == DateTime.Now)
            {
                MessageBox.Show("Please choose your birthday");
                dtp_birth.Focus();
            }
            else {
                check = BUS.UserBUS.Instance.register(txt_email.Text, txt_fname.Text, txt_lname.Text,txt_pwd.Text,gender.Text, dtp_birth.Value,cbb_city.Text);
            }

            if (check)
            {
                MessageBox.Show("Dang ky thanh cong");
                Login login = new Login();
                login.ShowDialog();
                this.Visible= false;
            }
            else
            {
                MessageBox.Show("Dang ky khong thanh cong");
            }

            
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_fname.Text = string.Empty;
            txt_lname.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_pwd.Text = string.Empty;
            cbb_city.Text = string.Empty;
            rdo_female.Checked = false;
            rdo_male.Checked = false;
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

        private bool IsValidPassword(string password)
        {
            int validConditions = 0;
            foreach (char c in password)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }
            if (password.Length >= 6)
            {
                validConditions++;
            }
            if (validConditions < 4)
            {
                return false;
            }
            else
            {
                char[] special = { '!', '@', '#', '$', '%', '^', '*', '?', '/', '(', ')' };
                if (password.IndexOfAny(special) >= 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        private bool IsValidName(String name)
        {
            foreach (char c in name)
            {
                if (c >= '0' && c <= '9')
                {
                    return false;
                }
                if (c < 'a' && c > 'z' && c < 'A' && c > 'Z') 
                {
                    return false;
                }
            }
            return true;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Visible = false;
        }

        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            txt_fname.Text = string.Empty;
            txt_lname.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_pwd.Text = string.Empty;
            cbb_city.Text = string.Empty;
            rdo_female.Checked = false;
            rdo_male.Checked = false;
        }
    }
}


