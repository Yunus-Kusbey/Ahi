using Esnaf.Application.Const.Enums;
using Esnaf.Application.DTOs.Auth;
using Esnaf.Application.Repositories;
using Esnaf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esnaf.Persistence.Repositories
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
                        }
                        return new UserAccessedLoginDTO { Role = roles, IsActive = (bool)outIsActive.Value, Id = (Guid)outId.Value, IsRegister = (bool)outRegister.Value };
                    }
                    return null;
                }
            }
        }

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetWhere()
        {
            throw new NotImplementedException();
        }
    }
}
