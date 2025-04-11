namespace FormFullMark
{
    partial class ChooseYourCategory
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(44, 53);
            label1.Name = "label1";
            label1.Size = new Size(293, 80);
            label1.TabIndex = 6;
            label1.Text = "Choose Your\r\n Game Category";
            label1.Click += label1_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kids and Toddlers", "Shooting and Fighting - Shooting ", "Shooting and Fighting - Fighting", "Sports and Racing - Sports ", "Sports and Racing - Racing" });
            comboBox1.Location = new Point(44, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(293, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(44, 204);
            label2.Name = "label2";
            label2.Size = new Size(249, 14);
            label2.TabIndex = 177;
            label2.Text = "This will erase all of your data on this form";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(44, 225);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 176;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ChooseYourCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrchid;
            BackgroundImage = Properties.Resources._5bfb0062_a349_4a6c_98ee_1ecc841f9244;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(379, 290);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "ChooseYourCategory";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button1;
    }
}