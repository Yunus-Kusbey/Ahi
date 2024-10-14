using Esnaf.Application.Repositories;
using Esnaf.Application.DTOs.Seller;
using System.Data.SqlClient;
using System.Data;

namespace Esnaf.Persistence.Repositories
{
    public class SellerWriteRepository : ISellerWriteRepository
    {
        public async Task<bool> AddAsync(SellerCreate entity)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblSellerInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@FK_userId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@shopName", SqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@VKN", SqlDbType.VarChar, 10);
                    cmd.Parameters.Add("@FK_addressId", SqlDbType.VarChar, 30);

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
                using (var cmd = new SqlCommand("usp_tblSellerDelete", con))
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
                using (var cmd = new SqlCommand("usp_tblSellerDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }
        public bool Update(SellerUpdate entity)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblSellerUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@shopName", SqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@VKN", SqlDbType.VarChar, 10);
                    cmd.Parameters.Add("@FK_addressId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit, 1);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}
