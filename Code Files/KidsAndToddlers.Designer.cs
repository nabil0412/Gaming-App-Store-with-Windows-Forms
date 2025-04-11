namespace FormFullMark
{
    partial class KidsAndToddlers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox3 = new ComboBox();
            label10 = new Label();
            comboBox2 = new ComboBox();
            label9 = new Label();
            label3 = new Label();
            button2 = new Button();
            label7 = new Label();
            label1 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "True", "False" });
            comboBox3.Location = new Point(40, 190);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(110, 23);
            comboBox3.TabIndex = 191;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveBorder;
            label10.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(41, 160);
            label10.Name = "label10";
            label10.Size = new Size(193, 22);
            label10.TabIndex = 186;
            label10.Text = "InteractiveElements";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "True", "False" });
            comboBox2.Location = new Point(40, 121);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(110, 23);
            comboBox2.TabIndex = 185;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveBorder;
            label9.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(41, 229);
            label9.Name = "label9";
            label9.Size = new Size(131, 22);
            label9.TabIndex = 183;
            label9.Text = "AgeRequired";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 92);
            label3.Name = "label3";
            label3.Size = new Size(118, 22);
            label3.TabIndex = 181;
            label3.Text = "Educational";
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkSlateBlue;
            button2.Location = new Point(401, 337);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(188, 40);
            button2.TabIndex = 177;
            button2.Text = "Join The Fun!";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGoldenrod;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(192, 40);
            label7.TabIndex = 176;
            label7.Text = "Game Info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(41, 320);
            label1.Name = "label1";
            label1.Size = new Size(249, 14);
            label1.TabIndex = 175;
            label1.Text = "This will erase all of your data on this form";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(41, 337);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 174;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(41, 258);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 202;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // KidsAndToddlers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5bfb0062_a349_4a6c_98ee_1ecc841f9244;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox3);
            Controls.Add(label10);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "KidsAndToddlers";
            Text = "AgeRequired";
            Load += KidsAndToddlers_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox3;
        private Label label10;
        private ComboBox comboBox2;
        private Label label9;
        private Label label3;
        private Button button2;
        private Label label7;
        private Label label1;
        private Button button1;
        private NumericUpDown numericUpDown1;
    }
}