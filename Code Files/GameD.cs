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
    public partial class GameD : Form
    {
        public HomePage x;
        Account account;
        public GameD()
        {
            InitializeComponent();
        }
        public GameD(HomePage x, Account account)
        {
            this.x = x;
            this.account = account;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            x.Visible = true;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0 || numericUpDown2.Value == 0 || comboBox3.SelectedIndex == -1 || textBox1.Text == "")
            {
                MessageBox.Show("Please Fill The Empty Fields");
            }
            else
            {

                Form category = new ChooseYourCategory(this, x, account);
                ((ChooseYourCategory)category).Show();
                //((ChooseYourCategory)(category)).Show();
                this.Visible = false;

            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void GameD_Load(object sender, EventArgs e)
        {

        }
    }
}
