using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryControl
{
    public static class DbClass
    {
        private static string connectionString = "server=localhost\\SQLEXPRESS;database=InventoryControl;user=inventoryControlUser;password=qwe#$rR123";

        public static DataTable ExecuteQuery(string query)
        {
            SqlConnection Con = new SqlConnection(connectionString);
            using (Con)
            {
                try
                {
                    Con.Open(); DataTable table = new DataTable();
                    using (SqlCommand command = new SqlCommand(query, Con))
                    {
                        var x = command.ExecuteReader();
                        table.Load(x);
                    }
                    Con.Close();
                    return table;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
