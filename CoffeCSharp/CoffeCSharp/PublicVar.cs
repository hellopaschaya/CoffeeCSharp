using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CoffeCSharp
{
    public static class PublicVar
    {
        public static int countRight = 0, cbbCustomer=0;
        public static bool buttonRightClick = false;
        public static SqlDataReader dr;
        public static DataSet ds = new DataSet();
        public static object dataum;
        public static string cusId = "", showRightTotal ="";
    }
}
