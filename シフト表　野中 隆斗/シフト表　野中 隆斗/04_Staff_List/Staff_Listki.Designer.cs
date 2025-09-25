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
            button1 = new Button();
            button2 = new Button();
            Add_Btn = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)StaffGridView).BeginInit();
            SuspendLayout();
            // 
            // StaffGridView
            // 
            StaffGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StaffGridView.Location = new Point(374, 136);
            StaffGridView.Name = "StaffGridView";
            StaffGridView.RowHeadersWidth = 62;
            StaffGridView.Size = new Size(1117, 782);
            StaffGridView.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(78, 134);
            button1.Name = "button1";
            button1.Size = new Size(152, 54);
            button1.TabIndex = 1;
            button1.Text = "マイページ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(78, 194);
            button2.Name = "button2";
            button2.Size = new Size(152, 54);
            button2.TabIndex = 2;
            button2.Text = "シフト設定";
            button2.UseVisualStyleBackColor = true;
            // 
            // Add_Btn
            // 
            Add_Btn.Location = new Point(78, 396);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(152, 54);
            Add_Btn.TabIndex = 3;
            Add_Btn.Text = "追加";
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // button4
            // 
            button4.Location = new Point(78, 456);
            button4.Name = "button4";
            button4.Size = new Size(152, 54);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(78, 516);
            button5.Name = "button5";
            button5.Size = new Size(152, 54);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(78, 583);
            button6.Name = "button6";
            button6.Size = new Size(152, 54);
            button6.TabIndex = 6;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(78, 724);
            button7.Name = "button7";
            button7.Size = new Size(152, 54);
            button7.TabIndex = 7;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(78, 805);
            button8.Name = "button8";
            button8.Size = new Size(152, 54);
            button8.TabIndex = 8;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // Staff_Listki
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1681, 1086);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(Add_Btn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(StaffGridView);
            Name = "Staff_Listki";
            Text = "Staff_List";
            Load += Staff_List_Load;
            ((System.ComponentModel.ISupportInitialize)StaffGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView StaffGridView;
        private Button button1;
        private Button button2;
        private Button Add_Btn;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}