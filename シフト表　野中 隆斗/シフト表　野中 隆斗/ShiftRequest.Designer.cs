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
            // SHTime
            // 
            SHTime.FormattingEnabled = true;
            SHTime.Location = new Point(132, 270);
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
            OMinTime.Location = new Point(735, 270);
            OMinTime.Name = "OMinTime";
            OMinTime.Size = new Size(75, 33);
            OMinTime.TabIndex = 8;
            // 
            // ShiftRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 582);
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
    }
}