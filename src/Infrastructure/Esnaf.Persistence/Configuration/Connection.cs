using System.Data.SqlClient;
using System.Data;

namespace Esnaf.Persistence
{
    static class Connection
    {
        static public string ConnectionString
        {
            get
            {
                return "Server=ABDULLAHYUNUS;Database=Esnaf;Trusted_Connection=True;MultipleActiveResultSets=true";
            }
        }
        static SqlConnection con = new SqlConnection(ConnectionString);
        static public void Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                 con.Open();
            }
        }
        static public void Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        static public SqlConnection SqlConnection()
        {
            return con;
        }
    }
}
