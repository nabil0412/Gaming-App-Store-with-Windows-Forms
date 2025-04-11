using Azure;
using Azure.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.Extensions.Msal;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormFullMark
{

    public partial class KidsAndToddlers : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Database_Project;Integrated Security=True;Encrypt=False;");

        ChooseYourCategory y;
        Account account;
        HomePage x;
        GameD gamed;


        public KidsAndToddlers()
        {
            InitializeComponent();
        }

        public KidsAndToddlers(ChooseYourCategory y, GameD gamed, HomePage x, Account account)
        {
            InitializeComponent();
            this.account = account;
            this.y = y;
            this.x = x;
            this.gamed = gamed;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            y.Visible = true;
            this.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (numericUpDown1.Value == 0 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
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
                decimal age_required = numericUpDown1.Value;
                string educational = comboBox2.Text;
                string interactive_elements = comboBox3.Text;


                con.Open();


                string stmt = "SELECT COUNT(storage_required) FROM KidsAndToddlers";
                string s_title = "Select COUNT(CreatorName) From Names";
                int counter1 = 0;
                int count = 0;

                SqlCommand cmdCount = new SqlCommand(stmt, con);
                SqlCommand cmdCount1 = new SqlCommand(s_title, con);
                count = (int)cmdCount.ExecuteScalar();
                counter1 = (int)cmdCount1.ExecuteScalar();
                
                SqlCommand cmd = new SqlCommand("insert into KidsAndToddlers values('" + count + "','" + storage_required.ToString() + "','" + number_of_users.ToString() + "','" + in_app_puchases + "','" + username + "','" + educational + "','" + interactive_elements + "','" + age_required.ToString() + "','"+ game_title + "')", con);
                string gametype = "KidsAndToddlers";
                SqlCommand cmd1 = new SqlCommand("insert into Names values('" + counter1 + "','" + username + "','" + game_title + "','" + gametype + "')" ,con);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery(); //to start inserting

                //con.Close();
                con.Close();

                this.Close();



                Form homepage = new HomePage(account);
                ((HomePage)(homepage)).Visible = true;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void KidsAndToddlers_Load(object sender, EventArgs e)
        {
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

