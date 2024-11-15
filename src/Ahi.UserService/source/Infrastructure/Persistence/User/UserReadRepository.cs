using Ahi.UserService.source.Application.Const.Enums;
using Ahi.UserService.source.Application.DTOs.Auth;
using Ahi.UserService.source.Domain.Interfaces.Repositories;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Ahi.UserService.source.Infrastructure.Persistence
{
    public class UserReadRepository : IUserReadRepository
    {
        public async Task<UserAccessedLoginDTO?> Control(string PhoneNumber)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblUserSelect", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar, 10).Value = PhoneNumber;
                    var outRole = new SqlParameter("role", SqlDbType.Char, 1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    var outIsActive = new SqlParameter("@isActive", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    var outId = new SqlParameter("@uid", SqlDbType.UniqueIdentifier)
                    {
                        Direction = ParameterDirection.Output
                    };
                    var outRegister = new SqlParameter("@register", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outRole);
                    cmd.Parameters.Add(outId);
                    cmd.Parameters.Add(outIsActive);
                    cmd.Parameters.Add(outRegister);
                    con.Open();

                    await cmd.ExecuteNonQueryAsync();
                    if ((Guid)outId.Value != Guid.Empty)
                    {
                        Roles roles = new();
                        switch ((string)outRole.Value)
                        {
                            case "0":
                                roles = Roles.Admin; break;
                            case "1":
                                roles = Roles.Customer; break;
                            case "2":
                                roles = Roles.Seller; break;
                            case "3":
                                roles = Roles.LoginSave; break;
                        }
                        return new UserAccessedLoginDTO { Role = roles, IsActive = (bool)outIsActive.Value, Id = (Guid)outId.Value, IsRegister = (bool)outRegister.Value };
                    }
                    return null;
                }
            }
        }

        public IQueryable GetAll()
        {
            throw new NotImplementedException();
        }

        public Task GetByIdAsync(int model)
        {
            throw new NotImplementedException();
        }

        public IQueryable GetWhere(int model)
        {
            throw new NotImplementedException();
        }
    }
}
