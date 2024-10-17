using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esnaf.Application.DTOs.Product;
using System.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Esnaf.Persistence.Repositories
{
    public class ProductPricesWriteRepository : IProductPriceWriteRepository
    {
        public async Task<Guid> AddAsync(ProductPriceCreateDTO entity)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblProductPriceInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FK_productId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 25);
                    cmd.Parameters.Add("@price", SqlDbType.Decimal, 9);
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
                using (var cmd = new SqlCommand("usp_tblProductPriceDelete", con))
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
                using (var cmd = new SqlCommand("usp_tblProductPriceDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public bool Update(ProductPriceUpdateDTO entity)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblProductPriceUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@FK_productId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 25);
                    cmd.Parameters.Add("@price", SqlDbType.Decimal, 9);
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit, 1);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}
