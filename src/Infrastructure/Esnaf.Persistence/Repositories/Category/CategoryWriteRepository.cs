using Esnaf.Application.Repositories;
using Esnaf.Application.DTOs.Category;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace Esnaf.Persistence.Repositories
{
    public class CategoryWriteRepository : ICategoryWriteRepository
    {
        public async Task<int> AddAsync(CategoryCreateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCategoryInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 20).Value = model.Name;
                    var ExistsParam = new SqlParameter("@exists", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(ExistsParam);
                    con.Open();
                    await cmd.ExecuteNonQueryAsync();
                    int userExists = (int)ExistsParam.Value;
                    return userExists;
                }
            }
        }

        public bool Delete(Guid id)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCategoryDelete", con))
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
                using (var cmd = new SqlCommand("usp_tblCategoryDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = id;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }
        public bool Update(CategoryUpdateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCategoryUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = model.Id;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 20).Value = model.Name;
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit, 1).Value = model.IsActived;

                    con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}
