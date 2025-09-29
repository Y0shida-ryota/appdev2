namespace シフト表_野中_隆斗
{
    public partial class Form_Login : System.Windows.Forms.Form
    {
        private int loginFailCount = 0;
        adminDB verification;
        public Form_Login()
        {
            InitializeComponent();
            verification = new adminDB(this.Nolabel,this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = ID_txt.Text;
            string passward = PS_txt.Text;

            verification.veriflcation(id, passward);

        }
    }
}
