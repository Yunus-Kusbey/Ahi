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
        public async Task<UserAccessedLoginDTO> Control(string PhoneNumber)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblUserSelect", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar, 10).Value = PhoneNumber;
                    var outRole = new SqlParameter("role",SqlDbType.Char, 1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    var outBool = new SqlParameter("@exists", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outRole);
                    cmd.Parameters.Add(outBool);
                    con.Open();
                    await cmd.ExecuteNonQueryAsync();
                    return new UserAccessedLoginDTO { Role=(string)outRole.Value,IsActive=(bool)outBool.Value};
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
