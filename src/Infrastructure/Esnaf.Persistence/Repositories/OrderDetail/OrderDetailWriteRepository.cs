using Esnaf.Application.Repositories;
using Esnaf.Application.DTOs.Order;
using System.Data.SqlClient;
using System.Data;

namespace Esnaf.Persistence.Repositories
{
    public class OrderDetailWriteRepository : IOrderDetailWriteRepository
    {
        public async Task<bool> AddAsync(OrderDetailCreate entity)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblOrderDetailInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FK_orderId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_productId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_productPrice", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@quantity", SqlDbType.Int, 4);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public bool Delete(Guid id)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblOrderDetailDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblOrderDetailDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public bool Update(OrderDetailUpdate entity)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblOrderDetailInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_orderId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_productId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_productPrice", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@quantity", SqlDbType.Int, 4);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}
