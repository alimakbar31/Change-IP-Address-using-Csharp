using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace change_ip
{
    class Fungsi
    {
        static SqlConnection cn;
        static SqlDataReader reader;

        //isi ComboBox
        public static void Set_ComboBox(string selectstring, string row, ComboBox box)
        {
            try
            {
                cn = koneksi.cn;
                cn.Open();
                SqlCommand cmd = new SqlCommand(selectstring, cn);


                reader = cmd.ExecuteReader();
                box.Items.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        box.Items.Add(reader[row]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                cn.Close();
            }
        }
    }
}