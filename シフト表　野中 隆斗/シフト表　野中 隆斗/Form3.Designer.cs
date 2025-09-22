namespace シフト表_野中_隆斗
{
    partial class Form3
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
            button2 = new Button();
            monthCalendar2 = new MonthCalendar();
            button3 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
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
            // 
            // button2
            // 
            button2.Location = new Point(12, 117);
            button2.Name = "button2";
            button2.Size = new Size(112, 57);
            button2.TabIndex = 1;
            button2.Text = "名簿";
            button2.UseVisualStyleBackColor = true;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(174, 72);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(174, 352);
            button3.Name = "button3";
            button3.Size = new Size(298, 104);
            button3.TabIndex = 4;
            button3.Text = "保存";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(531, 70);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(726, 255);
            textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(531, 352);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(457, 33);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(606, 396);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(63, 33);
            comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(697, 396);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(63, 33);
            comboBox3.TabIndex = 8;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(798, 396);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(63, 33);
            comboBox4.TabIndex = 9;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(889, 396);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(63, 33);
            comboBox5.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(675, 399);
            label1.Name = "label1";
            label1.Size = new Size(16, 25);
            label1.TabIndex = 11;
            label1.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(867, 399);
            label2.Name = "label2";
            label2.Size = new Size(16, 25);
            label2.TabIndex = 12;
            label2.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(768, 399);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 13;
            label3.Text = "~";
            // 
            // button4
            // 
            button4.Location = new Point(578, 447);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 14;
            button4.Text = "追加";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(732, 447);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 15;
            button5.Text = "削除";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(889, 447);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 16;
            button6.Text = "クリア";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 501);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(monthCalendar2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "シフト設定";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private MonthCalendar monthCalendar2;
        private Button button3;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}