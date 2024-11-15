using Ahi.UserService.source.Application.DTOs;
using Ahi.UserService.source.Application.DTOs.User;
using Ahi.UserService.source.Domain.Interfaces.Repositories;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Ahi.UserService.source.Infrastructure.Persistence
{
    internal class UserWriteRepository : IUserWriteRepository
    {
        public async Task<Guid> AddAsync(CreateUserDTO model)
        {

            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblUserInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar, 10).Value = model.Phone;
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
                using (var cmd = new SqlCommand("usp_tblUserDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = id;

                    con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
        public async Task<bool> RemoveAsync(Guid id)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblUserDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = id;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public async Task<bool> UpdateAsync(UpdateUserDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblUserUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = model.Id;
                    cmd.Parameters.Add("isActive", SqlDbType.Bit, 1).Value = model.IsActive;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public Task<bool> UserInfoAddAsync(CreateUserInfoDTO create)
        {
            throw new NotImplementedException();
        }
    }
}
