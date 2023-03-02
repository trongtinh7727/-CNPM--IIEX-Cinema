using System;

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class UserBUS
    {
        private static UserBUS instance;

        public static UserBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserBUS();
                return instance;
            }
        }
        private UserBUS() { }
        public void view(DataGridView dgv)
        {

            dgv.DataSource = DAO.UserDAO.Instance.selectAll();

        }

        public void load_City(ComboBox cbb)
        {
            cbb.DataSource = DAO.UserDAO.Instance.loadCity();
        }
        public void viewByCity(DataGridView dgv, string city)
        {
            dgv.DataSource = DAO.UserDAO.Instance.selectByCity(city);
        }
        public bool Login(string email, string password)
        {
            return DAO.UserDAO.Instance.Login(email, password);
        }

        public bool register(string email, string fname, string lname, string pwd, string gender, DateTime birth, string city)
        {

            return false;
            DAO.UserDAO.Instance.register(email, fname, lname, pwd, gender, birth, city
                );

        }
    }
}
