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

namespace FormFullMark
{
    public partial class HomePage : System.Windows.Forms.Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Database_Project;Integrated Security=True;Encrypt=False;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        Account account;

        public HomePage()
        {
            InitializeComponent();
            showdata();
        }

        public HomePage(Account account)
        {
            InitializeComponent();
            showdata();
            this.account = account;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form generalgameinfo = new GameD(this, account);
            ((GameD)(generalgameinfo)).Show();
            this.Visible = false;
        }
        public void showdata()
        {
            adpt = new SqlDataAdapter("select * from Names", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    
    }
}
