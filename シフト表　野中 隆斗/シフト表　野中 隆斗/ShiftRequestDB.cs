using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace シフト表_野中_隆斗
{
    internal class ShiftRequestDB
    {
        private string connectionString;
        public ShiftRequestDB()
        {
            this.connectionString = DBHelper.connectionstring;
        }
       
    }
}
