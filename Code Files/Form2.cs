using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;



namespace MainProject
{
    public partial class Form2 : Form
    {

        bool flag1 = true;
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Database_Project;Integrated Security=True;Encrypt=False;");
        
        public Form1 f1;
        public Form3 f3;
        public Form2()
        {
            InitializeComponent();
        }


        public Form2(Form1 f1,Form3 f3)
        {
            InitializeComponent();
            this.f1 = f1;
            this.f3 = f3;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            f1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            flag1 = true;

            if (textBox1.Text == "" || textBox2.Text == " " || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {

                MessageBox.Show("One or more fields left empty!");

            }

            else
            {

                string first_name = f1.textBox1.Text;
                string last_name = f1.textBox2.Text;
                string user_name = f1.textBox3.Text;
                string password = f1.textBox4.Text;
                int id = 0;
                int age = 0;
                int storage = 0;
                int ram = 0;

                
                char[] stringArray = password.ToCharArray();

                Array.Reverse(stringArray);

                password = new string(stringArray);

                try
                {

                    age = int.Parse(this.textBox1.Text);

                }

                catch
                {
                    MessageBox.Show("Age must be a number");
                    flag1 = false;

                }




                string gender = this.comboBox1.Text;
                string device_name = this.textBox3.Text;
                string os = this.textBox4.Text;





                try
                {
                    storage = int.Parse(this.textBox5.Text);

                }

                catch
                {
                    MessageBox.Show("Storage must be a number");
                    flag1 = false;

                }



                try
                {
                    ram = int.Parse(this.textBox2.Text);
                }

                catch
                {
                    MessageBox.Show("RAM must be a number");
                    flag1 = false;
                }


                if (flag1 == true)
                {
                    string stmt = "SELECT COUNT(first_name) FROM Accountss";

                    int count = 0;

                    con.Open();

                    SqlCommand cmdCount = new SqlCommand(stmt, con);

                    count = (int)cmdCount.ExecuteScalar();





                    SqlCommand cmd = new SqlCommand("insert into Accountss values('" + count + "','" + first_name + "','" + last_name + "','" + user_name + "','" + password + "','" + age.ToString() + "','" + gender + "','" + device_name + "','" + os + "','" + storage.ToString() + "','" + ram.ToString() + "')", con);


                    cmd.ExecuteNonQuery(); //to start inserting

                    //con.Close();
                    con.Close();


                    this.Close();

                    f3.Show();
                }

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
