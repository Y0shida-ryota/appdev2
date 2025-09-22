using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace シフト表_野中_隆斗
{
    internal class DBHelper
    {
        public DBHelper()
        {

        }
        public static string connectionstring
        {
            get
            {
                return "Server=PB-B0024029\\SORIMACHI2022;Database=nonaka;User ID=sa;Password=shoo0127;TrustServerCertificate=True;";
            }

        }


    }
}
