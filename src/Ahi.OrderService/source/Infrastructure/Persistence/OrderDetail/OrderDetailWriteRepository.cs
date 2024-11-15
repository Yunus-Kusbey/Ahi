using Ahi.OrderService.source.Application.DTOs.Order;
using Ahi.OrderService.source.Domain.Interfaces.Persistence;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Ahi.OrderService.source.Infrastructure.Persistence
{
    public class OrderDetailWriteRepository : IOrderDetailWriteRepository
    {
        public async Task<Guid> AddAsync(OrderDetailCreateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblOrderDetailInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FK_orderId", SqlDbType.UniqueIdentifier, 16).Value = model.OrderId;
                    cmd.Parameters.Add("@FK_productId", SqlDbType.UniqueIdentifier, 16).Value = model.ProductId;
                    cmd.Parameters.Add("@FK_productPrice", SqlDbType.UniqueIdentifier, 16).Value = model.ProductPriceId;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int, 4).Value = model.Quantity;
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
                using (var cmd = new SqlCommand("usp_tblOrderDetailDelete", con))
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
                using (var cmd = new SqlCommand("usp_tblOrderDetailDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = id;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public async Task<bool> UpdateAsync(OrderDetailUpdateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblOrderDetailInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = model.Id;
                    cmd.Parameters.Add("@FK_orderId", SqlDbType.UniqueIdentifier, 16).Value = model.OrderId;
                    cmd.Parameters.Add("@FK_productId", SqlDbType.UniqueIdentifier, 16).Value = model.ProductId;
                    cmd.Parameters.Add("@FK_productPrice", SqlDbType.UniqueIdentifier, 16).Value = model.ProductId;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int, 4).Value = model.Quantity;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }
    }
}
