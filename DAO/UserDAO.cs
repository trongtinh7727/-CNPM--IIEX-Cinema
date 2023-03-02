using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAO
{
    public class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance
        {
            get { if(instance == null)
                    instance = new UserDAO();
                    return instance;
             }
        }
        private UserDAO() { }

        public List<User> selectAll() { 
            List<User> users = new List<User>();
            string sql = "Select * from usertable";
            DataTable dataTable= DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow row in dataTable.Rows)
            {
                string id = row["ID"].ToString();
                string username = row["username"].ToString();
                string email = row["email"].ToString();
                string fname = row["firstName"].ToString();
                string lname = row["lastName"].ToString();
                string pwd = row["pwd"].ToString();
                string gender = row["gender"].ToString();
            
                DateTime? birthday = row["birth"].ToString() == string.Empty ? null :(DateTime?) DateTime.Parse(row["birth"].ToString());
                string city = row["city"].ToString();

                User useN = new User(id, username, email, fname, lname, pwd, gender, birthday, city);
                users.Add(useN);

            }
            return users;
        }
        
       public List<User> selectByCity(string city)
        {
            List<User> users = new List<User>();
            string sql = "exec SelectUserCountry @city ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql,new object[] {city});

            foreach (DataRow row in dataTable.Rows)
            {
                string id = row["ID"].ToString();
                string username = row["username"].ToString();
                string email = row["email"].ToString();
                string fname = row["firstName"].ToString();
                string lname = row["lastName"].ToString();
                string pwd = row["pwd"].ToString();
                string gender = row["gender"].ToString();

                DateTime? birthday = row["birth"].ToString() == string.Empty ? null : (DateTime?)DateTime.Parse(row["birth"].ToString());
             

                User useN = new User(id, username, email, fname, lname, pwd, gender, birthday, city);
                users.Add(useN);

            }
            return users;
        }
        public List<string> loadCity()
        {
            List<string> citys = new List<string>();
            citys.Add("All");
            string sql = "Select city from usertable order by city";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql);
            foreach(DataRow row in dataTable.Rows) { 
                citys.Add(row["city"].ToString());
            }
            return citys;
        }
        public bool Login(string email, string password)
        {
            string procname = "exec Login @email , @password";
            using (DataTable dataTable = DataProvider.Instance.ExecuteQuery(procname, new object[] {email, password}))
            {
               
                DataRow row = dataTable.Rows[0];
                return row["Result"].ToString().Equals("true") ? true: false;
            }
        }

        public bool register(string email, string fname, string lname, string pwd, string gender, DateTime birth, string city)
        {
            string sql = "insert into UserTable values(@email , @fname , @lname , @pwd , @gender , @birth , @city) ";
            int i = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { email, fname, lname, pwd, gender, birth, city });
            if(i == 0)
            {
                return false;
            }
            return true;
        }
    }
}
