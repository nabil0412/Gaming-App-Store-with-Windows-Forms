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
    public partial class FightingD : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Database_Project;Integrated Security=True;Encrypt=False;");
        Account account;
        HomePage x;
        GameD gamed;
        ChooseYourCategory chooseyourcategory;

        public FightingD()
        {
            InitializeComponent();
        }


        public FightingD(ChooseYourCategory chooseyourcategory, GameD gamed, HomePage x, Account account)
        {
            this.chooseyourcategory = chooseyourcategory;
            this.gamed = gamed;
            this.x = x;
            this.account = account;
            InitializeComponent();
        }

        private void FightingD_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
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

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
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
            if (numericUpDown1.Value == 0 ||
                numericUpDown2.Value == 0 ||
                textBox6.Text == "" ||
                textBox5.Text == "" ||
                textBox4.Text == "" ||
                textBox8.Text == "" ||
                comboBox1.SelectedIndex == -1 ||
                comboBox2.SelectedIndex == -1 ||
                comboBox3.SelectedIndex == -1 ||
                comboBox4.SelectedIndex == -1 ||
                comboBox5.SelectedIndex == -1 ||
                comboBox6.SelectedIndex == -1)
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
                string os = textBox6.Text;
                string graphic_content = comboBox3.Text;
                string online = comboBox2.Text;
                string controlscheme = textBox5.Text;
                string bossbattles = comboBox5.Text;
                decimal number_of_levels = numericUpDown1.Value;
                string crossplatform = comboBox4.Text;
                string openworld = comboBox1.Text;
                string character_customization = comboBox6.Text;
                string gamemode = textBox4.Text;
                string weapontypes = textBox8.Text;


                con.Open();


                string stmt = "SELECT COUNT(username) FROM Fighting";
                string s_title = "Select COUNT(CreatorName) FROM Names";
                int counter1 = 0;

                int count = 0;

                SqlCommand cmdCount = new SqlCommand(stmt, con);
                SqlCommand cmdCount1 = new SqlCommand(s_title, con);

                count = (int)cmdCount.ExecuteScalar();
                counter1 = (int)cmdCount1.ExecuteScalar();

                SqlCommand cmd = new SqlCommand("insert into Fighting values('" + count + "','" + storage_required.ToString() + "','" + number_of_users.ToString() + "','" + in_app_puchases + "','" + username + "','" + ram_required.ToString() + "','" + os + "','" + graphic_content + "','" + online + "','" + controlscheme + "','" + bossbattles + "','" + number_of_levels.ToString() + "','" + crossplatform + "','" + openworld + "','" + character_customization + "','" + gamemode + "','" + weapontypes + "','" + game_title + "')", con);
                string gametype = "Fighting";
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
