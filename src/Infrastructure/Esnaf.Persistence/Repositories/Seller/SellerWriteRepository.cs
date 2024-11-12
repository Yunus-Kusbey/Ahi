using Esnaf.Application.Repositories;
using Esnaf.Application.DTOs.Seller;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace Esnaf.Persistence.Repositories
{
    public class SellerWriteRepository : ISellerWriteRepository
    {
        public async Task<Guid> AddAsync(SellerCreateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblSellerInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@FK_userId", SqlDbType.VarChar, 10).Value = model.PhoneNumber;
                    cmd.Parameters.Add("@shopName", SqlDbType.VarChar, 50).Value = model.ShopName;
                    cmd.Parameters.Add("@VKN", SqlDbType.VarChar, 10).Value = model.VKN;
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
                using (var cmd = new SqlCommand("usp_tblSellerDelete", con))
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
                using (var cmd = new SqlCommand("usp_tblSellerDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = id;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }
        public bool Update(SellerUpdateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblSellerUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = model.Id;
                    cmd.Parameters.Add("@shopName", SqlDbType.VarChar, 50).Value = model.ShopName;
                    cmd.Parameters.Add("@VKN", SqlDbType.VarChar, 10).Value = model.VKN;
                    cmd.Parameters.Add("@FK_addressId", SqlDbType.UniqueIdentifier, 16).Value = model.AddressId;
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit, 1).Value = model.IsActive;

                    con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}
