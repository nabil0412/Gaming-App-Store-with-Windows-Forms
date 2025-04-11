using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormFullMark
{
    public partial class Race : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Database_Project;Integrated Security=True;Encrypt=False;");
        Account account;
        HomePage x;
        GameD gamed;
        ChooseYourCategory chooseyourcategory;
        public Race()
        {
            InitializeComponent();
        }

        public Race(ChooseYourCategory chooseyourcategory, GameD gamed, HomePage x, Account account)
        {
            this.chooseyourcategory = chooseyourcategory;
            this.gamed = gamed;
            this.x = x;
            this.account = account;
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
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

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
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

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0 ||
                numericUpDown2.Value == 0 ||
                numericUpDown3.Value == 0 ||
                textBox2.Text == "" ||
                textBox3.Text == "" ||
                textBox5.Text == "" ||
                textBox6.Text == "" ||
                comboBox1.SelectedIndex == -1 ||
                comboBox3.SelectedIndex == -1 ||
                comboBox4.SelectedIndex == -1 ||
                numericUpDown4.Value == 0)
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

                decimal ram_required = numericUpDown1.Value;
                string online = comboBox1.Text;
                string coop = comboBox3.Text;
                string crossplatform = comboBox4.Text;
                decimal difficultylevels = numericUpDown2.Value;
                string graphics = textBox3.Text;
                string type = textBox5.Text;
                string vehicle = textBox6.Text;
                decimal number_of_races = numericUpDown3.Value;
                string gamemodes = textBox2.Text;
                decimal locations = numericUpDown4.Value;





                con.Open();


                string stmt = "SELECT COUNT(username) FROM Racing";
                string s_title = "Select COUNT(CreatorName) From Names";
                int counter1 = 0;

                int count = 0;

                SqlCommand cmdCount = new SqlCommand(stmt, con);
                SqlCommand cmdCount1 = new SqlCommand(s_title, con);

                count = (int)cmdCount.ExecuteScalar();
                counter1 = (int)cmdCount1.ExecuteScalar();

                SqlCommand cmd = new SqlCommand("insert into Racing values('" + count + "','" + storage_required.ToString() + "','" + number_of_users.ToString() + "','" + in_app_puchases + "','" + username + "','" + ram_required.ToString() + "','" + online + "','" + coop + "','" + crossplatform + "','" + difficultylevels.ToString() + "','" + graphics + "','" + type + "','" + vehicle + "','" + number_of_races.ToString() + "','" + gamemodes + "','" + locations.ToString() + "','" + game_title + "')", con);
                string gametype = "Racing";
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
