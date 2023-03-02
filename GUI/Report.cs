using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frm_Report : Form
    {
        public frm_Report()
        {
            InitializeComponent();
        }

        private void frm_Report_Load(object sender, EventArgs e)
        {
            cbb_city_picker.SelectedItem = null;
            cbb_city_picker.SelectedText = "--select--";

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            BUS.UserBUS.Instance.load_City(cbb_city_picker);
            BUS.UserBUS.Instance.view(dgv_user);

        }

        private void cbb_city_picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_city_picker.Text == "All")
            {
                BUS.UserBUS.Instance.view(dgv_user);
            }
            else
            {
                BUS.UserBUS.Instance.viewByCity(dgv_user, cbb_city_picker.Text);
            }
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
