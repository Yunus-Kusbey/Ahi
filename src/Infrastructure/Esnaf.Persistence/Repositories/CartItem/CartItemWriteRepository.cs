using Esnaf.Application.Repositories;
using Esnaf.Application.DTOs.Cart;
using System.Data;
using System.Data.SqlClient;

namespace Esnaf.Persistence.Repositories
{
    public class CartItemWriteRepository : ICartItemWriteRepository
    {
        public async Task<bool> AddAsync(CartItemCreate entity)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCartItemInsert",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FK_cartId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_productId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_productPriceId", SqlDbType.UniqueIdentifier, 16);
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
                using (var cmd = new SqlCommand("usp_tblCartItemDelete",con))
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
                using (var cmd = new SqlCommand("usp_tblCartItemDelete",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = id;

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }
        public bool Update(CartItemUpdate entity)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCartItemUpdate",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.Int, 4);
                    cmd.Parameters.Add(("@FK_cartId", SqlDbType.UniqueIdentifier, 16));
                    cmd.Parameters.Add("@FK_productId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_productPriceId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@quantity", SqlDbType.Int, 4);
                    cmd.Parameters.Add("@total", SqlDbType.Decimal, 9);
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit, 1);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}