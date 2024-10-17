using Esnaf.Application.Repositories;
using Esnaf.Application.DTOs.Cart;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace Esnaf.Persistence.Repositories
{
    public class CartWriteRepository : ICartWriteRepository
    {
        public async Task<Guid> AddAsync(CartCreateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCartInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FK_customerId", SqlDbType.UniqueIdentifier, 16).Value = model.CustomerId;
                    cmd.Parameters.Add("@FK_sellerId", SqlDbType.UniqueIdentifier, 16).Value = model.SellerId;
                    cmd.Parameters.Add("@total", SqlDbType.Decimal, 9).Value = model.Total;
                    var ExistsParam = new SqlParameter("@exists", SqlDbType.UniqueIdentifier)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(ExistsParam);
                    con.Open();
                    await cmd.ExecuteNonQueryAsync();
                    Guid userExists = (Guid)ExistsParam.Value;
                    return userExists;
                }
            }
        }
        public bool Delete(Guid id)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCartDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = id;

                    con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCartDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = id;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public bool Update(CartUpdateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCartUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = model.Id;
                    cmd.Parameters.Add("@isActived", SqlDbType.Bit, 1).Value = model.IsActive;

                    con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}
