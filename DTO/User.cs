using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    
    public class User
    {
        private string id;
        private string username;
        private string email;
        private string fname;
        private string lname;
        private string password;
        private string gender;
        private DateTime? birthday;
        private string city;

        public User(string id, string username, string email, string fname, string lname, string password, string gender, DateTime? birthday, string city)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.fname = fname;
            this.lname = lname;
            this.password = password;
            this.gender = gender;
            this.birthday = birthday;
            this.city = city;
        }

        public User(string username, string email, string fname, string lname, string password, string gender, DateTime? birthday, string city)
        {
            this.username = username;
            this.email = email;
            this.fname = fname;
            this.lname = lname;
            this.password = password;
            this.gender = gender;
            this.birthday = birthday;
            this.city = city;
        }

        public string UserId
        {
            get { return id; }
            set { id = value; }
        }
    
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }

        }
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        
        public DateTime? Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
      
    }
}
