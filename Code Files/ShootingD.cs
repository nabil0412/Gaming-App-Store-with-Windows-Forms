using MainProject;
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
    public partial class ShootingD : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Database_Project;Integrated Security=True;Encrypt=False;");
        Account account;
        HomePage x;
        GameD gamed;
        ChooseYourCategory chooseyourcategory;
        Form3 Start;
        public ShootingD()
        {
            InitializeComponent();
        }


        public ShootingD(ChooseYourCategory chooseyourcategory, GameD gamed, HomePage x, Account account)
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShootingD_Load(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0 || textBox6.Text == "" || comboBox3.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || textBox5.Text == "" || comboBox5.SelectedIndex == -1 || numericUpDown3.Value == 0 || comboBox4.SelectedIndex == -1 || textBox3.Text == "" || numericUpDown2.Value == 0 || textBox4.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Please Fill The Empty Fields");
            }
            else
            {
                string username = account.username;
                decimal storage_required = gamed.numericUpDown2.Value;
                decimal number_of_users = gamed.numericUpDown1.Value;
                string in_app_puchases = gamed.comboBox3.Text;
                string game_title = gamed.textBox1.Text;

                decimal ram_required = numericUpDown1.Value;
                string os = textBox6.Text;
                string graphic_content = comboBox3.Text;
                string online = comboBox2.Text;
                string controlscheme = textBox5.Text;
                string bossbattles = comboBox5.Text;
                decimal number_of_levels = numericUpDown3.Value;
                string crossplatform = comboBox4.Text;
                string type = textBox3.Text;
                decimal number_of_maps = numericUpDown2.Value;
                string gamemode = textBox4.Text;
                string guntype = textBox8.Text;


                con.Open();


                string stmt = "SELECT COUNT(storage_required) FROM Shooting";
                string s_title = "Select COUNT(CreatorName) From Names";

                int counter1 = 0;
                int count = 0;

                SqlCommand cmdCount = new SqlCommand(stmt, con);
                SqlCommand cmdCount1 = new SqlCommand(s_title, con);


                count = (int)cmdCount.ExecuteScalar();
                counter1 = (int)cmdCount1.ExecuteScalar();

                SqlCommand cmd = new SqlCommand("insert into Shooting values('" + count + "','" + storage_required.ToString() + "','" + number_of_users.ToString() + "','" + in_app_puchases + "','" + username + "','" + ram_required.ToString() + "','" + os + "','" + graphic_content + "','" + online + "','" + controlscheme + "','" + bossbattles + "','" + number_of_levels.ToString() + "','" + crossplatform + "','" + type + "','" + number_of_maps.ToString() + "','" + gamemode + "','" + guntype + "','" + game_title + "')", con);
                string gametype = "Shooting";
                SqlCommand cmd1 = new SqlCommand("insert into Names values('" + counter1 + "','" + username + "','" + game_title + "','" + gametype + "')", con);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery(); //to start inserting

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
