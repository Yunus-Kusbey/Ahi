using Esnaf.Application.Repositories;
using Esnaf.Application.DTOs.Order;
using System.Data.SqlClient;
using System.Data;

namespace Esnaf.Persistence.Repositories
{
    public class OrderWriteRepository : IOrderWriteRepository
    {
        public async Task<bool> AddAsync(OrderCreate entity)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblOrderInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FK_customerId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_paymentId", SqlDbType.Char, 1);
                    cmd.Parameters.Add("@total", SqlDbType.Decimal, 9);
                    cmd.Parameters.Add("@FK_sellerId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_status", SqlDbType.Char, 1);

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
                using (var cmd = new SqlCommand("usp_tblOrderDelete", con))
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
                using (var cmd = new SqlCommand("usp_tblOrderDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public bool Update(OrderUpdate entity)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblOrderUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_customerId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_paymentId", SqlDbType.Char, 1);
                    cmd.Parameters.Add("@total", SqlDbType.Decimal, 9);
                    cmd.Parameters.Add("@FK_sellerId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_status", SqlDbType.Char, 1);
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit, 1);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}
