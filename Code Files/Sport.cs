using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormFullMark
{
    public partial class Sport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Database_Project;Integrated Security=True;Encrypt=False;");
        Account account;
        HomePage x;
        GameD gamed;
        ChooseYourCategory chooseyourcategory;

        public Sport()
        {
            InitializeComponent();
        }


        public Sport(ChooseYourCategory chooseyourcategory, GameD gamed, HomePage x, Account account)
        {
            this.chooseyourcategory = chooseyourcategory;
            this.gamed = gamed;
            this.x = x;
            this.account = account;
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (numericUpDown2.Value == 0 ||
                textBox2.Text == "" ||
                textBox3.Text == "" ||
                textBox5.Text == "" ||
                textBox6.Text == "" ||
                textBox7.Text == "" ||
                comboBox1.SelectedIndex == -1 ||
                comboBox3.SelectedIndex == -1 ||
                comboBox4.SelectedIndex == -1 ||
                comboBox5.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {

                string username = account.username;
                decimal storage_required = gamed.numericUpDown2.Value;
                decimal number_of_users = gamed.numericUpDown1.Value;
                string in_app_puchases = gamed.comboBox3.Text;
                string game_title = gamed.textBox1.Text;

                decimal ram_required = numericUpDown2.Value;
                string online = comboBox1.Text;
                string coop = comboBox3.Text;
                string crossplatform = comboBox4.Text;
                string gamemode = textBox2.Text;
                string diffculty = comboBox5.Text;
                string graphics = textBox3.Text;
                string sport = textBox5.Text;
                string commentary_language = textBox6.Text;
                string cover_player = textBox7.Text;



                con.Open();


                string stmt = "SELECT COUNT(username) FROM sport";
                string s_title = "Select COUNT(CreatorName) From Names";
                int counter1 = 0;
                int count = 0;

                SqlCommand cmdCount = new SqlCommand(stmt, con);
                SqlCommand cmdCount1= new SqlCommand(s_title, con);
                count = (int)cmdCount.ExecuteScalar();
                counter1 = (int)cmdCount1.ExecuteScalar();

                SqlCommand cmd = new SqlCommand("insert into sport values('" + count + "','" + storage_required.ToString() + "','" + number_of_users.ToString() + "','" + in_app_puchases + "','" + username + "','" + ram_required.ToString() + "','" + online + "','" + coop + "','" + crossplatform + "','" + gamemode + "','" + diffculty + "','" + graphics + "','" + sport + "','" + commentary_language + "','" + cover_player + "','" + game_title + "')", con);
                string gametype = "Sports";
                SqlCommand cmd1 = new SqlCommand("insert into Names values('" + counter1 + "','" + username + "','" + game_title + "','" + gametype + "')", con);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();

                //con.Close();
                con.Close();

                this.Close();



                Form homepage = new HomePage(account);
                ((HomePage)(homepage)).Visible = true;



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chooseyourcategory.Visible = true;
            this.Close();
        }
    }
}
