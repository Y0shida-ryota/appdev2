using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace シフト表_野中_隆斗
{

    public partial class ShiftRequest : Form
    {
       
        public commonNonakaItem Item;
        public commonNonakaDB commoDB;
        public ShiftRequest()
        {
            InitializeComponent();
            Item = new commonNonakaItem(this.yearComboBox, this.mbMonth, this.cmbDay, this.SHTime, this.SMinTime, this.OHTime, this.OMinTime);
            commoDB = new commonNonakaDB(this.IDBox, this.namelabel);
        }

        private void ShiftRequest_Load(object sender, EventArgs e)
        {
            


        }
    }
}
