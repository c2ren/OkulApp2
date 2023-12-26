using System;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL  //Data Access Layer
{
    public class Helper
    {
        SqlConnection baglanti;
        SqlCommand cmd;

        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            using (baglanti = new SqlConnection(cstr))
            {
                using (cmd = new SqlCommand(cmdtext,baglanti)) 
                {
                    if (p != null)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    baglanti.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            
        }
    }
}
