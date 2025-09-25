namespace シフト表_野中_隆斗
{
    partial class Form_shift_change_desired_notification
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
            delete_btn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 29);
            button1.Name = "button1";
            button1.Size = new Size(133, 74);
            button1.TabIndex = 0;
            button1.Text = "マイページ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(778, 49);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(179, 54);
            delete_btn.TabIndex = 1;
            delete_btn.Text = "確認済を削除";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(975, 281);
            dataGridView1.TabIndex = 2;
            // 
            // Form_shift_change_desired_notification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 450);
            Controls.Add(dataGridView1);
            Controls.Add(delete_btn);
            Controls.Add(button1);
            Name = "Form_shift_change_desired_notification";
            Text = "Formシフト変更希望通知画面";
            Load += Form_shift_change_desired_notification_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button delete_btn;
        private DataGridView dataGridView1;
    }
}