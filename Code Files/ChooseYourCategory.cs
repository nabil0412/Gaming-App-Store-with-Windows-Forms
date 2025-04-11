
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
    public partial class ChooseYourCategory : System.Windows.Forms.Form
    {
        Account account;
        HomePage x;
        GameD gamed;
        public ChooseYourCategory()
        {
            InitializeComponent();
        }

        public ChooseYourCategory(GameD gamed, HomePage x, Account account)
        {
            InitializeComponent();
            this.account = account;
            this.gamed = gamed;
            this.x = x;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Form KidsAndToddlers101 = new KidsAndToddlers(this, gamed, x, account);
                ((KidsAndToddlers)(KidsAndToddlers101)).Show();
                this.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Form Shooting101 = new ShootingD(this, gamed, x, account);
                ((ShootingD)(Shooting101)).Show();
                this.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Form Fighting101 = new FightingD(this, gamed, x, account);
                ((FightingD)(Fighting101)).Show();
                this.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Form Sport101 = new Sport(this, gamed, x, account);
                ((Sport)(Sport101)).Show();
                this.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Form Racing101 = new Race(this, gamed, x, account);
                ((Race)(Racing101)).Show();
                this.Visible = false;
            }



        }



        private void button1_Click(object sender, EventArgs e)
        {
            x.Visible = true;
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

