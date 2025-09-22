namespace シフト表_野中_隆斗
{
    public partial class Form1 : Form
    {
        private int loginFailCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = ID_txt.Text;
            string passward = PS_txt.Text;

            if (id == " " && passward == " ") 
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                loginFailCount++;
                label3.Text = "入力が正しくありません。";

                if (loginFailCount > 3)
                {
                    MessageBox.Show("三回間違えたのでアプリを終了します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }
}
