namespace シフト表_野中_隆斗
{
    partial class Form
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
            button1 = new Button();
            Staff_Namebtn = new Button();
            monthCalendar2 = new MonthCalendar();
            Save_btn = new Button();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            deletion_btn = new Button();
            Add_btn = new Button();
            clear_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 44);
            button1.Name = "button1";
            button1.Size = new Size(112, 57);
            button1.TabIndex = 0;
            button1.Text = "マイページ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Staff_Namebtn
            // 
            Staff_Namebtn.Location = new Point(12, 131);
            Staff_Namebtn.Name = "Staff_Namebtn";
            Staff_Namebtn.Size = new Size(112, 57);
            Staff_Namebtn.TabIndex = 1;
            Staff_Namebtn.Text = "名簿";
            Staff_Namebtn.UseVisualStyleBackColor = true;
            Staff_Namebtn.Click += Staff_Namebtn_Click;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(174, 72);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 3;
            // 
            // Save_btn
            // 
            Save_btn.Location = new Point(174, 352);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(298, 104);
            Save_btn.TabIndex = 4;
            Save_btn.Text = "保存";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(531, 70);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(726, 255);
            textBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "" });
            comboBox2.Location = new Point(544, 391);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(58, 33);
            comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "00", "15", "30", "45" });
            comboBox3.Location = new Point(641, 391);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(58, 33);
            comboBox3.TabIndex = 8;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            comboBox4.Location = new Point(743, 389);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(58, 33);
            comboBox4.TabIndex = 9;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "00", "15", "30", "45" });
            comboBox5.Location = new Point(843, 389);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(58, 33);
            comboBox5.TabIndex = 10;
            // 
            // deletion_btn
            // 
            deletion_btn.Location = new Point(807, 455);
            deletion_btn.Name = "deletion_btn";
            deletion_btn.Size = new Size(192, 34);
            deletion_btn.TabIndex = 11;
            deletion_btn.Text = "削除";
            deletion_btn.UseVisualStyleBackColor = true;
            deletion_btn.Click += deletion_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.Location = new Point(531, 455);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(192, 34);
            Add_btn.TabIndex = 12;
            Add_btn.Text = "追加";
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(1065, 455);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(192, 34);
            clear_btn.TabIndex = 13;
            clear_btn.Text = "クリア";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(605, 394);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 14;
            label1.Text = "：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(807, 394);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 15;
            label2.Text = "：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(707, 392);
            label3.Name = "label3";
            label3.Size = new Size(30, 25);
            label3.TabIndex = 16;
            label3.Text = "～";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(859, 29);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(531, 331);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(301, 33);
            comboBox1.TabIndex = 18;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 501);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clear_btn);
            Controls.Add(Add_btn);
            Controls.Add(deletion_btn);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(Save_btn);
            Controls.Add(monthCalendar2);
            Controls.Add(Staff_Namebtn);
            Controls.Add(button1);
            Name = "Form3";
            Text = "シフト設定";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button Staff_Namebtn;
        private MonthCalendar monthCalendar2;
        private Button Save_btn;
        private TextBox textBox1;
        private ComboBox LoadStaffTocomboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Button deletion_btn;
        private Button Add_btn;
        private Button clear_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
    }
}