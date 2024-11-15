using System.Data;
using Ahi.UserService.source.Application.DTOs.Address;
using Ahi.UserService.source.Domain.Interfaces.Repositories.Address;
using Microsoft.Data.SqlClient;

namespace Ahi.UserService.source.Infrastructure.Persistence
{
    public class AddressWriteRepository : IAddressWriteRepository
    {
        public async Task<Guid> AddAsync(AddressCreateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblAddressInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FK_customerId", SqlDbType.UniqueIdentifier, 16).Value = model.CustomerId;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 20).Value = model.Name;
                    cmd.Parameters.Add("@FK_province", SqlDbType.Char, 2).Value = model.ProvinceId;
                    cmd.Parameters.Add("@FK_county", SqlDbType.Char, 4).Value = model.CountyId;
                    cmd.Parameters.Add("@openAddress", SqlDbType.VarChar, 50).Value = model.OpenAddress;
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

        public bool Remove(Guid id)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblAddressDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value=id;

                    con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
        public async Task<bool> RemoveAsync(Guid id)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblAddressDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value=id;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public async Task<bool> UpdateAsync(AddressUpdateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblAddressUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value=model.Id;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 20).Value=model.Name;
                    cmd.Parameters.Add("@FK_province", SqlDbType.Char, 2).Value=model.ProvinceId;
                    cmd.Parameters.Add("@FK_county", SqlDbType.Char, 4).Value=model.CountyId;
                    cmd.Parameters.Add("@openAddress", SqlDbType.VarChar, 50).Value=model.OpenAddress;
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit, 1).Value=model.IsActive;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }
    }
}