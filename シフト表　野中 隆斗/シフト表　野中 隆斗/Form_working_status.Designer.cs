namespace シフト表_野中_隆斗
{
    partial class Form_working_status
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
            components = new System.ComponentModel.Container();
            returnbtn = new Button();
            dataGridView1 = new DataGridView();
            timelabel = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // returnbtn
            // 
            returnbtn.Location = new Point(12, 38);
            returnbtn.Name = "returnbtn";
            returnbtn.Size = new Size(146, 71);
            returnbtn.TabIndex = 0;
            returnbtn.Text = "マイページ";
            returnbtn.UseVisualStyleBackColor = true;
            returnbtn.Click += returnbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(189, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(576, 354);
            dataGridView1.TabIndex = 1;
            // 
            // timelabel
            // 
            timelabel.AutoSize = true;
            timelabel.Location = new Point(406, 30);
            timelabel.Name = "timelabel";
            timelabel.Size = new Size(17, 25);
            timelabel.TabIndex = 2;
            timelabel.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 38);
            label1.Name = "label1";
            label1.Size = new Size(17, 25);
            label1.TabIndex = 3;
            label1.Text = " ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form_working_status
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(timelabel);
            Controls.Add(dataGridView1);
            Controls.Add(returnbtn);
            Name = "Form_working_status";
            Text = "Form_working_status";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnbtn;
        private DataGridView dataGridView1;
        private Label timelabel;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}