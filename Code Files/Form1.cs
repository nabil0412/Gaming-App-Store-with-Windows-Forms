using Microsoft.Data.SqlClient;

namespace MainProject
{
    public partial class Form1 : Form
    {
        public Form3 f3;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Form3 f3)
        {
            InitializeComponent();
            this.f3 = f3;
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Passwords dont match!");

            }

            else
            {


                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    string user_name = textBox3.Text;
                    SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Database_Project;Integrated Security=True;Encrypt=False;");
                    con.Open();
                    SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [Accountss] WHERE ([username] = @user)", con);
                    check_User_Name.Parameters.AddWithValue("@user", user_name);

                    int i = (int)check_User_Name.ExecuteScalar();

                    if (i > 0)
                    {
                        MessageBox.Show("Username already exists");

                    }

                    else
                    {

                        Form form2 = new Form2(this, f3);
                        this.Visible = false;
                        ((Form2)form2).Show();
                    }

                }

                else
                {

                    MessageBox.Show("One or more fields not filled!");

                }
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
