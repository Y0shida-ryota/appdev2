namespace シフト表_野中_隆斗
{
    partial class ShiftRequest
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
            namelabel = new Label();
            IDBox = new ComboBox();
            yearComboBox = new ComboBox();
            mbMonth = new ComboBox();
            cmbDay = new ComboBox();
            SHTime = new ComboBox();
            SMinTime = new ComboBox();
            OHTime = new ComboBox();
            OMinTime = new ComboBox();
            AddButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            EndButton = new Button();
            SuspendLayout();
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(541, 92);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(84, 25);
            namelabel.TabIndex = 0;
            namelabel.Text = "鳥取砂丘";
            // 
            // IDBox
            // 
            IDBox.FormattingEnabled = true;
            IDBox.Location = new Point(346, 89);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(166, 33);
            IDBox.TabIndex = 1;
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(192, 162);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(166, 33);
            yearComboBox.TabIndex = 2;
            // 
            // mbMonth
            // 
            mbMonth.FormattingEnabled = true;
            mbMonth.Location = new Point(431, 162);
            mbMonth.Name = "mbMonth";
            mbMonth.Size = new Size(166, 33);
            mbMonth.TabIndex = 3;
            // 
            // cmbDay
            // 
            cmbDay.FormattingEnabled = true;
            cmbDay.Location = new Point(644, 162);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(166, 33);
            cmbDay.TabIndex = 4;
            // 
            // SHTime
            // 
            SHTime.FormattingEnabled = true;
            SHTime.Location = new Point(192, 270);
            SHTime.Name = "SHTime";
            SHTime.Size = new Size(75, 33);
            SHTime.TabIndex = 5;
            // 
            // SMinTime
            // 
            SMinTime.FormattingEnabled = true;
            SMinTime.Location = new Point(315, 270);
            SMinTime.Name = "SMinTime";
            SMinTime.Size = new Size(75, 33);
            SMinTime.TabIndex = 6;
            // 
            // OHTime
            // 
            OHTime.FormattingEnabled = true;
            OHTime.Location = new Point(522, 270);
            OHTime.Name = "OHTime";
            OHTime.Size = new Size(75, 33);
            OHTime.TabIndex = 7;
            // 
            // OMinTime
            // 
            OMinTime.FormattingEnabled = true;
            OMinTime.Location = new Point(644, 270);
            OMinTime.Name = "OMinTime";
            OMinTime.Size = new Size(75, 33);
            OMinTime.TabIndex = 8;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(208, 409);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(190, 95);
            AddButton.TabIndex = 9;
            AddButton.Text = "完了";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 92);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 10;
            label1.Text = "依頼先　ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 165);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 11;
            label2.Text = "依頼勤務日";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 170);
            label3.Name = "label3";
            label3.Size = new Size(30, 25);
            label3.TabIndex = 12;
            label3.Text = "年";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 273);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 13;
            label4.Text = "依頼勤務時間";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 273);
            label5.Name = "label5";
            label5.Size = new Size(30, 25);
            label5.TabIndex = 14;
            label5.Text = "：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(603, 273);
            label6.Name = "label6";
            label6.Size = new Size(30, 25);
            label6.TabIndex = 15;
            label6.Text = "：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(431, 273);
            label7.Name = "label7";
            label7.Size = new Size(30, 25);
            label7.TabIndex = 16;
            label7.Text = "～";
            // 
            // EndButton
            // 
            EndButton.Location = new Point(522, 409);
            EndButton.Name = "EndButton";
            EndButton.Size = new Size(190, 95);
            EndButton.TabIndex = 17;
            EndButton.Text = "キャンセル";
            EndButton.UseVisualStyleBackColor = true;
            EndButton.Click += EndButton_Click;
            // 
            // ShiftRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 582);
            Controls.Add(EndButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Controls.Add(OMinTime);
            Controls.Add(OHTime);
            Controls.Add(SMinTime);
            Controls.Add(SHTime);
            Controls.Add(cmbDay);
            Controls.Add(mbMonth);
            Controls.Add(yearComboBox);
            Controls.Add(IDBox);
            Controls.Add(namelabel);
            Name = "ShiftRequest";
            Text = "ShiftRequest";
            Load += ShiftRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namelabel;
        private ComboBox IDBox;
        private ComboBox yearComboBox;
        private ComboBox mbMonth;
        private ComboBox cmbDay;
        private ComboBox SHTime;
        private ComboBox SMinTime;
        private ComboBox OHTime;
        private ComboBox OMinTime;
        private Button AddButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button EndButton;
    }
}