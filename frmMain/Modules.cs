using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace frmMain
{
    class Modules
    {
        public static string cnnStr = "";
        public static SqlConnection cnn = new SqlConnection(cnnStr);
    }
}
