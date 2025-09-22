namespace シフト表_野中_隆斗
{
    partial class Form_Add
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
            name_Lb = new Label();
            phonenumber_Lb = new Label();
            emailaddress_Lb = new Label();
            bank_account_Lb = new Label();
            address_Lb = new Label();
            commute_Lb = new Label();
            completed_Btn = new Button();
            cancel_Btn = new Button();
            NameBox = new TextBox();
            TellBox = new TextBox();
            e_mailBox = new TextBox();
            bankBox = new TextBox();
            AddressBox = new TextBox();
            howBox = new TextBox();
            SuspendLayout();
            // 
            // name_Lb
            // 
            name_Lb.AutoSize = true;
            name_Lb.Location = new Point(174, 29);
            name_Lb.Name = "name_Lb";
            name_Lb.Size = new Size(66, 25);
            name_Lb.TabIndex = 0;
            name_Lb.Text = "名前：";
            // 
            // phonenumber_Lb
            // 
            phonenumber_Lb.AutoSize = true;
            phonenumber_Lb.Location = new Point(174, 83);
            phonenumber_Lb.Name = "phonenumber_Lb";
            phonenumber_Lb.Size = new Size(102, 25);
            phonenumber_Lb.TabIndex = 1;
            phonenumber_Lb.Text = "電話番号：";
            // 
            // emailaddress_Lb
            // 
            emailaddress_Lb.AutoSize = true;
            emailaddress_Lb.Location = new Point(174, 144);
            emailaddress_Lb.Name = "emailaddress_Lb";
            emailaddress_Lb.Size = new Size(124, 25);
            emailaddress_Lb.TabIndex = 2;
            emailaddress_Lb.Text = "メールアドレス：";
            // 
            // bank_account_Lb
            // 
            bank_account_Lb.AutoSize = true;
            bank_account_Lb.Location = new Point(174, 198);
            bank_account_Lb.Name = "bank_account_Lb";
            bank_account_Lb.Size = new Size(102, 25);
            bank_account_Lb.TabIndex = 3;
            bank_account_Lb.Text = "銀行口座：";
            // 
            // address_Lb
            // 
            address_Lb.AutoSize = true;
            address_Lb.Location = new Point(174, 255);
            address_Lb.Name = "address_Lb";
            address_Lb.Size = new Size(66, 25);
            address_Lb.TabIndex = 4;
            address_Lb.Text = "住所：";
            // 
            // commute_Lb
            // 
            commute_Lb.AutoSize = true;
            commute_Lb.Location = new Point(174, 315);
            commute_Lb.Name = "commute_Lb";
            commute_Lb.Size = new Size(84, 25);
            commute_Lb.TabIndex = 5;
            commute_Lb.Text = "通勤手段";
            // 
            // completed_Btn
            // 
            completed_Btn.Location = new Point(232, 384);
            completed_Btn.Name = "completed_Btn";
            completed_Btn.Size = new Size(112, 34);
            completed_Btn.TabIndex = 6;
            completed_Btn.Text = "完了";
            completed_Btn.UseVisualStyleBackColor = true;
            completed_Btn.Click += completed_Btn_Click;
            // 
            // cancel_Btn
            // 
            cancel_Btn.Location = new Point(401, 384);
            cancel_Btn.Name = "cancel_Btn";
            cancel_Btn.Size = new Size(112, 34);
            cancel_Btn.TabIndex = 7;
            cancel_Btn.Text = "キャンセル";
            cancel_Btn.UseVisualStyleBackColor = true;
            cancel_Btn.Click += cancel_Btn_Click;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(317, 26);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(286, 31);
            NameBox.TabIndex = 8;
            // 
            // TellBox
            // 
            TellBox.Location = new Point(317, 80);
            TellBox.Name = "TellBox";
            TellBox.Size = new Size(286, 31);
            TellBox.TabIndex = 9;
            // 
            // e_mailBox
            // 
            e_mailBox.Location = new Point(317, 141);
            e_mailBox.Name = "e_mailBox";
            e_mailBox.Size = new Size(286, 31);
            e_mailBox.TabIndex = 10;
            // 
            // bankBox
            // 
            bankBox.Location = new Point(317, 195);
            bankBox.Name = "bankBox";
            bankBox.Size = new Size(286, 31);
            bankBox.TabIndex = 11;
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(317, 252);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(286, 31);
            AddressBox.TabIndex = 12;
            // 
            // howBox
            // 
            howBox.Location = new Point(317, 312);
            howBox.Name = "howBox";
            howBox.Size = new Size(286, 31);
            howBox.TabIndex = 13;
            // 
            // Form_Add
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(howBox);
            Controls.Add(AddressBox);
            Controls.Add(bankBox);
            Controls.Add(e_mailBox);
            Controls.Add(TellBox);
            Controls.Add(NameBox);
            Controls.Add(cancel_Btn);
            Controls.Add(completed_Btn);
            Controls.Add(commute_Lb);
            Controls.Add(address_Lb);
            Controls.Add(bank_account_Lb);
            Controls.Add(emailaddress_Lb);
            Controls.Add(phonenumber_Lb);
            Controls.Add(name_Lb);
            Name = "Form_Add";
            Text = "Form_Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_Lb;
        private Label phonenumber_Lb;
        private Label emailaddress_Lb;
        private Label bank_account_Lb;
        private Label address_Lb;
        private Label commute_Lb;
        private Button completed_Btn;
        private Button cancel_Btn;
        private TextBox NameBox;
        private TextBox TellBox;
        private TextBox e_mailBox;
        private TextBox bankBox;
        private TextBox AddressBox;
        private TextBox howBox;
    }
}