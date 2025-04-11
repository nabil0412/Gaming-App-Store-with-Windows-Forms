using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FormFullMark
{
    public  class  Account
    {

        public string first_name;
        public string last_name;
        public string username;
        private string password;
        private int age;
        private string gender;
        public Device device;


        public Account() { }

        public Account(string first_name, string last_name, string username, string password, int age, string gender, Device device)
        {

            this.first_name = first_name;
            this.last_name = last_name;
            this.username = username;
            this.password = password;
            this.age = age;
            this.gender = gender;
            this.device = device;

        }

        // public Image profile_picture; -> howa msh dah I think we dont need here


        public string Password
        {
            set { password = value; }   
            get { return password; }
        }


        public string Gender
        {
            get { return gender; }
            set { if ((value == "male") || (value == "Male") || (value == "Female") || (value == "female"))
                    gender = value;
                 }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 1)
                {
                    age = value;
                }
            }
        }


    
    }
}
