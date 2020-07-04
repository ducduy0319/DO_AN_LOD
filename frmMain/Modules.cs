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
        public static string cnnStr = "Data Source=DESKTOP-SR3BE2S\\SQLEXPRESS;Initial Catalog=QL_LKDT_LOD;Integrated Security=True";
        public static SqlConnection cnn = new SqlConnection(cnnStr);
    }
}
