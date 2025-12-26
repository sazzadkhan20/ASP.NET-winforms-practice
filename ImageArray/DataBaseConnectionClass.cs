using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ImageArray
{
    class DataBaseConnectionClass
    {
        public SqlConnection con;
        public void dbcon()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zohur\Downloads\OneDrive_1_1-14-2025\ImageProcessing.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
        }

    }
}
