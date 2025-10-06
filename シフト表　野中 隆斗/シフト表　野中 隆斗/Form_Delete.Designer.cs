namespace シフト表_野中_隆斗
{
    partial class Form_Delete
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
            ID_Lb = new Label();
            namelabel = new Label();
            ID_Cb = new ComboBox();
            Delete_Btn = new Button();
            cencel_Btn = new Button();
            SuspendLayout();
            // 
            // ID_Lb
            // 
            ID_Lb.AutoSize = true;
            ID_Lb.Location = new Point(151, 94);
            ID_Lb.Name = "ID_Lb";
            ID_Lb.Size = new Size(30, 25);
            ID_Lb.TabIndex = 0;
            ID_Lb.Text = "ID";
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(171, 170);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(180, 25);
            namelabel.TabIndex = 1;
            namelabel.Text = "IDが選択されていません";
            // 
            // ID_Cb
            // 
            ID_Cb.FormattingEnabled = true;
            ID_Cb.Location = new Point(187, 91);
            ID_Cb.Name = "ID_Cb";
            ID_Cb.Size = new Size(182, 33);
            ID_Cb.TabIndex = 2;
            // 
            // Delete_Btn
            // 
            Delete_Btn.Location = new Point(81, 242);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.Size = new Size(112, 34);
            Delete_Btn.TabIndex = 3;
            Delete_Btn.Text = "削除";
            Delete_Btn.UseVisualStyleBackColor = true;
            Delete_Btn.Click += Delete_Btn_Click;
            // 
            // cencel_Btn
            // 
            cencel_Btn.Location = new Point(325, 242);
            cencel_Btn.Name = "cencel_Btn";
            cencel_Btn.Size = new Size(112, 34);
            cencel_Btn.TabIndex = 4;
            cencel_Btn.Text = "キャンセル";
            cencel_Btn.UseVisualStyleBackColor = true;
            cencel_Btn.Click += cencel_Btn_Click;
            // 
            // Form_Delete
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 350);
            Controls.Add(cencel_Btn);
            Controls.Add(Delete_Btn);
            Controls.Add(ID_Cb);
            Controls.Add(namelabel);
            Controls.Add(ID_Lb);
            Name = "Form_Delete";
            Text = "削除";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID_Lb;
        private Label namelabel;
        private ComboBox ID_Cb;
        private Button Delete_Btn;
        private Button cencel_Btn;
    }
}