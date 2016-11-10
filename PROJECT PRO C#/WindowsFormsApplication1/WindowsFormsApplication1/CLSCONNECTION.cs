using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class CLSCONNECTION
    {
        public SqlConnection SQLCON;
        public SqlCommand SQLCOM;
        public SqlDataReader SQLREAD;
        public string CONSTRING; //connection string variable
        public string SQLPROC; //variable used for procedure


        public string myconnection()
        {
            this.CONSTRING = WindowsFormsApplication1.Properties.Settings.Default.ICON.ToString();

            return CONSTRING;
        }

    }
}