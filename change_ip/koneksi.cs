using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace change_ip
{
    class koneksi
    {
        public static SqlConnection cn = new SqlConnection("Data Source = 192.168.9.250; Initial Catalog = db_model; User ID = XMI_SUPPORT; Password=Passw0rd");
        public static DataTable getdatatable(string selectString)
        {
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(selectString, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                cn.Close();
            }
#pragma warning disable 0168
            catch (Exception ex)
            { }
            return dt;
        }
    }
}
