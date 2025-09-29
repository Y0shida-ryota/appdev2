namespace シフト表_野中_隆斗
{
    partial class Form2
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
            Shift_settingbtn = new Button();
            name_listbtn = new Button();
            working_statusbtn = new Button();
            notificationbtn = new Button();
            END_btn = new Button();
            SuspendLayout();
            // 
            // Shift_settingbtn
            // 
            Shift_settingbtn.Location = new Point(96, 218);
            Shift_settingbtn.Name = "Shift_settingbtn";
            Shift_settingbtn.Size = new Size(141, 86);
            Shift_settingbtn.TabIndex = 0;
            Shift_settingbtn.Text = "シフト設定";
            Shift_settingbtn.UseVisualStyleBackColor = true;
            Shift_settingbtn.Click += Shift_settingbtn_Click;
            // 
            // name_listbtn
            // 
            name_listbtn.Location = new Point(316, 218);
            name_listbtn.Name = "name_listbtn";
            name_listbtn.Size = new Size(141, 86);
            name_listbtn.TabIndex = 1;
            name_listbtn.Text = "名簿";
            name_listbtn.UseVisualStyleBackColor = true;
            name_listbtn.Click += name_listbtn_Click;
            // 
            // working_statusbtn
            // 
            working_statusbtn.Location = new Point(536, 218);
            working_statusbtn.Name = "working_statusbtn";
            working_statusbtn.Size = new Size(141, 86);
            working_statusbtn.TabIndex = 2;
            working_statusbtn.Text = "勤務状況";
            working_statusbtn.UseVisualStyleBackColor = true;
            working_statusbtn.Click += working_statusbtn_Click;
            // 
            // notificationbtn
            // 
            notificationbtn.Location = new Point(460, 26);
            notificationbtn.Name = "notificationbtn";
            notificationbtn.Size = new Size(159, 34);
            notificationbtn.TabIndex = 3;
            notificationbtn.Text = "シフト変更希望通知";
            notificationbtn.UseVisualStyleBackColor = true;
            notificationbtn.Click += notificationbtn_Click;
            // 
            // END_btn
            // 
            END_btn.Location = new Point(659, 26);
            END_btn.Name = "END_btn";
            END_btn.Size = new Size(112, 34);
            END_btn.TabIndex = 4;
            END_btn.Text = "終了";
            END_btn.UseVisualStyleBackColor = true;
            END_btn.Click += END_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(END_btn);
            Controls.Add(notificationbtn);
            Controls.Add(working_statusbtn);
            Controls.Add(name_listbtn);
            Controls.Add(Shift_settingbtn);
            Name = "Form2";
            Text = "ダッシュボード";
            ResumeLayout(false);
        }

        #endregion

        private Button Shift_settingbtn;
        private Button name_listbtn;
        private Button working_statusbtn;
        private Button notificationbtn;
        private Button END_btn;
    }
}