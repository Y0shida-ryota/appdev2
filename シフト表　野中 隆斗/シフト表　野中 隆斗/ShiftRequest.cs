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
            //Item.InitYearComboBox(this.yearComboBox, 2020, 2030);
            //Item.InitMonthComboBox(this.mbMonth);
            //int year = Item.GetSelectedValue(this.yearComboBox);
            //int month = Item.GetSelectedValue(this.mbMonth);
            //Item.InitDayComboBox(cmbDay, year, month);
            //Item.InHTime(this.SHTime);
            //Item.InMinTime(this.SMinTime);
            //Item.InHTime(this.OHTime);
            //Item.InMinTime(this.OMinTime);


        }
    }
}
