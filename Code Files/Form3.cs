using FormFullMark;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.Extensions.Msal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(this);
            f1.Show();
            this.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_name = textBox1.Text;
            string password = textBox2.Text;
            string first_name = "x";
            string last_name = "y";
            int age = 1;
            string gender = "tobedetermined";
            string device_name = "device";
            string os = "os";
            int storage = 1;
            int ram = 1;

            char[] stringArray = password.ToCharArray();
            Array.Reverse(stringArray);
            password = new string(stringArray);

            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Database_Project;Integrated Security=True;Encrypt=False;");

            con.Open();


            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [Accountss] WHERE ([username] = @user AND [password] = @password)", con);

            check_User_Name.Parameters.AddWithValue("@user", user_name);

            check_User_Name.Parameters.AddWithValue("@password", password);

            int i = (int)check_User_Name.ExecuteScalar();




            if (i > 0)
            {


                string getUserInfoQuery = "SELECT first_name, last_name,username,password, age, gender, device_name, operating_system, storage, ram FROM [Accountss] WHERE [username] = @user";
                SqlCommand vmb = new SqlCommand(getUserInfoQuery, con);

                vmb.Parameters.AddWithValue("@user", user_name);

                SqlDataReader reader1;

                reader1 = vmb.ExecuteReader();

                if (reader1.Read())
                {
                    first_name = reader1["first_name"].ToString();
                    last_name = reader1["last_name"].ToString();
                    user_name = reader1["username"].ToString();
                    password = reader1["password"].ToString();
                    age = Convert.ToInt32(reader1["age"]);
                    gender = reader1["gender"].ToString();
                    device_name = reader1["device_name"].ToString();
                    os = reader1["operating_system"].ToString();
                    storage = Convert.ToInt32(reader1["storage"]);
                    ram = Convert.ToInt32(reader1["ram"]);

                }

                Device device = new Device(device_name, os, storage, ram);
                Account LoggedIn = new Account(first_name, last_name, user_name, password, age, gender, device);


                Form homepage_start = new HomePage(LoggedIn);
                ((HomePage)(homepage_start)).Visible = true;
                this.Visible = false;




            }
            else
            {

                MessageBox.Show("Incorrect username or password");

            }

            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
