using Esnaf.Application.Repositories;
using Esnaf.Application.DTOs.Product;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace Esnaf.Persistence.Repositories
{
    public class ProductWriteRepository : IProductWriteRepository
    {
        public async Task<Guid> AddAsync(ProductCreateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblProductInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 25).Value = model.Name;
                    cmd.Parameters.Add("@description", SqlDbType.VarChar, 300).Value = model.Description;
                    cmd.Parameters.Add("@summary", SqlDbType.VarChar, 50).Value = model.Summary;
                    cmd.Parameters.Add("@FK_categoryId", SqlDbType.Int, 4).Value = model.CategoryId;
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
                using (var cmd = new SqlCommand("usp_tblProductDelete", con))
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
                using (var cmd = new SqlCommand("usp_tblProductDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = id;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }
        public bool Update(ProductUpdateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblProductUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = model.Id;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 25).Value = model.Name;
                    cmd.Parameters.Add("@description", SqlDbType.VarChar, 300).Value = model.Description;
                    cmd.Parameters.Add("@summary", SqlDbType.VarChar, 50).Value = model.Summary;
                    cmd.Parameters.Add("@FK_categoryId", SqlDbType.Int, 4).Value = model.CategoryId;
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit, 1).Value = model.IsActive;

                    con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}
