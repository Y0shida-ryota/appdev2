namespace シフト表_野中_隆斗
{
    partial class Staff_Listki
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
            StaffGridView = new DataGridView();
            RequestButton = new Button();
            mypage_Btn = new Button();
            setting_Btn = new Button();
            Add_Btn = new Button();
            edit_Btn = new Button();
            delete_Btn = new Button();
            save_Btn = new Button();
            back_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)StaffGridView).BeginInit();
            SuspendLayout();
            // 
            // StaffGridView
            // 
            StaffGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StaffGridView.Location = new Point(195, 12);
            StaffGridView.Name = "StaffGridView";
            StaffGridView.RowHeadersWidth = 62;
            StaffGridView.Size = new Size(1431, 1046);
            StaffGridView.TabIndex = 0;
            // 
            // RequestButton
            // 
            RequestButton.Location = new Point(12, 518);
            RequestButton.Name = "RequestButton";
            RequestButton.Size = new Size(159, 60);
            RequestButton.TabIndex = 1;
            RequestButton.Text = "依頼";
            RequestButton.UseVisualStyleBackColor = true;
            RequestButton.Click += RequestButton_Click;
            // 
            // mypage_Btn
            // 
            mypage_Btn.Location = new Point(12, 21);
            mypage_Btn.Name = "mypage_Btn";
            mypage_Btn.Size = new Size(159, 60);
            mypage_Btn.TabIndex = 2;
            mypage_Btn.Text = "マイページ";
            mypage_Btn.UseVisualStyleBackColor = true;
            mypage_Btn.Click += mypage_Btn_Click;
            // 
            // setting_Btn
            // 
            setting_Btn.Location = new Point(12, 87);
            setting_Btn.Name = "setting_Btn";
            setting_Btn.Size = new Size(159, 60);
            setting_Btn.TabIndex = 3;
            setting_Btn.Text = "シフト設定";
            setting_Btn.UseVisualStyleBackColor = true;
            setting_Btn.Click += setting_Btn_Click;
            // 
            // Add_Btn
            // 
            Add_Btn.Location = new Point(12, 273);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(159, 60);
            Add_Btn.TabIndex = 4;
            Add_Btn.Text = "追加";
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // edit_Btn
            // 
            edit_Btn.Location = new Point(12, 350);
            edit_Btn.Name = "edit_Btn";
            edit_Btn.Size = new Size(159, 60);
            edit_Btn.TabIndex = 5;
            edit_Btn.Text = "編集";
            edit_Btn.UseVisualStyleBackColor = true;
            edit_Btn.Click += edit_Btn_Click;
            // 
            // delete_Btn
            // 
            delete_Btn.Location = new Point(12, 432);
            delete_Btn.Name = "delete_Btn";
            delete_Btn.Size = new Size(159, 60);
            delete_Btn.TabIndex = 6;
            delete_Btn.Text = "削除";
            delete_Btn.UseVisualStyleBackColor = true;
            delete_Btn.Click += delete_Btn_Click;
            // 
            // save_Btn
            // 
            save_Btn.Location = new Point(12, 684);
            save_Btn.Name = "save_Btn";
            save_Btn.Size = new Size(159, 60);
            save_Btn.TabIndex = 7;
            save_Btn.Text = "編集内容の保存";
            save_Btn.UseVisualStyleBackColor = true;
            save_Btn.Visible = false;
            save_Btn.Click += save_Btn_Click;
            // 
            // back_Btn
            // 
            back_Btn.Location = new Point(12, 764);
            back_Btn.Name = "back_Btn";
            back_Btn.Size = new Size(159, 60);
            back_Btn.TabIndex = 7;
            back_Btn.Text = "元に戻す";
            back_Btn.UseVisualStyleBackColor = true;
            back_Btn.Visible = false;
            back_Btn.Click += back_Btn_Click;
            // 
            // Staff_Listki
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1681, 1086);
            Controls.Add(back_Btn);
            Controls.Add(save_Btn);
            Controls.Add(delete_Btn);
            Controls.Add(edit_Btn);
            Controls.Add(Add_Btn);
            Controls.Add(setting_Btn);
            Controls.Add(mypage_Btn);
            Controls.Add(RequestButton);
            Controls.Add(StaffGridView);
            Name = "Staff_Listki";
            Text = "名簿";
            Load += Staff_List_Load;
            ((System.ComponentModel.ISupportInitialize)StaffGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView StaffGridView;
        private Button RequestButton;
        private Button mypage_Btn;
        private Button setting_Btn;
        private Button Add_Btn;
        private Button edit_Btn;
        private Button delete_Btn;
        private Button save_Btn;
        private Button back_Btn;
    }
}