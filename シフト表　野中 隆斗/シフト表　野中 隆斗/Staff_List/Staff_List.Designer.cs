namespace シフト表_野中_隆斗
{
    partial class Staff_List
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
            // Staff_List
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1681, 1086);
            Controls.Add(StaffGridView);
            Name = "Staff_List";
            Text = "Staff_List";
            Load += Staff_List_Load;
            ((System.ComponentModel.ISupportInitialize)StaffGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView StaffGridView;
    }
}