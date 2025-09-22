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
            comboBox1.Location = new Point(531, 364);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 501);
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
    }
}