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
            comboBox1 = new ComboBox();
            yearComboBox = new ComboBox();
            mbMonth = new ComboBox();
            cmbDay = new ComboBox();
            SuspendLayout();
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(541, 92);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(56, 25);
            namelabel.TabIndex = 0;
            namelabel.Text = "dddd";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(315, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 33);
            comboBox1.TabIndex = 1;
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(144, 162);
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
            // ShiftRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 582);
            Controls.Add(cmbDay);
            Controls.Add(mbMonth);
            Controls.Add(yearComboBox);
            Controls.Add(comboBox1);
            Controls.Add(namelabel);
            Name = "ShiftRequest";
            Text = "ShiftRequest";
            Load += ShiftRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namelabel;
        private ComboBox comboBox1;
        private ComboBox yearComboBox;
        private ComboBox mbMonth;
        private ComboBox cmbDay;
    }
}