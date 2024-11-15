using Microsoft.Data.SqlClient;

namespace Ahi.SellerService.source.Infrastructure.Persistence
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
        static public SqlConnection SqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
