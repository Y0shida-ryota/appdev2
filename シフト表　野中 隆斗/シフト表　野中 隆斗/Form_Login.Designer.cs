namespace シフト表_野中_隆斗
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            ID_txt = new TextBox();
            PS_txt = new TextBox();
            label3 = new Label();
            Nolabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(250, 261);
            button1.Name = "button1";
            button1.Size = new Size(272, 109);
            button1.TabIndex = 0;
            button1.Text = "ログイン";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 98);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "管理者ID ：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 170);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 2;
            label2.Text = "パスワード：";
            // 
            // ID_txt
            // 
            ID_txt.Location = new Point(288, 95);
            ID_txt.Name = "ID_txt";
            ID_txt.Size = new Size(234, 31);
            ID_txt.TabIndex = 3;
            // 
            // PS_txt
            // 
            PS_txt.Location = new Point(288, 170);
            PS_txt.Name = "PS_txt";
            PS_txt.Size = new Size(234, 31);
            PS_txt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 35);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 5;
            // 
            // Nolabel
            // 
            Nolabel.AutoSize = true;
            Nolabel.ForeColor = Color.Brown;
            Nolabel.Location = new Point(295, 45);
            Nolabel.Name = "Nolabel";
            Nolabel.Size = new Size(175, 25);
            Nolabel.TabIndex = 6;
            Nolabel.Text = "入力が正しくありません";
            Nolabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Nolabel);
            Controls.Add(label3);
            Controls.Add(PS_txt);
            Controls.Add(ID_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "管理者ログインページ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox ID_txt;
        private TextBox PS_txt;
        private Label label3;
        private Label Nolabel;
    }
}
