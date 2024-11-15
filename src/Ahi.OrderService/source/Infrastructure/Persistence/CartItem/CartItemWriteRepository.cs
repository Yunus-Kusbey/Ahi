using Ahi.OrderService.source.Application.DTOs.Cart;
using Ahi.OrderService.source.Domain.Interfaces.Persistence;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Ahi.OrderService.source.Infrastructure.Persistence
{
    public class CartItemWriteRepository : ICartItemWriteRepository
    {
        public async Task<int> AddAsync(CartItemCreateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCartItemInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FK_cartId", SqlDbType.UniqueIdentifier, 16).Value = model.CartId;
                    cmd.Parameters.Add("@FK_productId", SqlDbType.UniqueIdentifier, 16).Value = model.ProductId;
                    cmd.Parameters.Add("@FK_productPriceId", SqlDbType.UniqueIdentifier, 16).Value = model.ProductPriceId;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int, 4).Value = model.Quantity;
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

        public bool Remove(int id)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCartItemDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = id;

                    con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
        public async Task<bool> RemoveAsync(int id)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCartItemDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = id;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }
        public async Task<bool> UpdateAsync(CartItemUpdateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCartItemUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.Int, 4).Value = model.Id;
                    cmd.Parameters.Add("@FK_cartId", SqlDbType.UniqueIdentifier, 16).Value = model.CartId;
                    cmd.Parameters.Add("@FK_productId", SqlDbType.UniqueIdentifier, 16).Value = model.ProductId;
                    cmd.Parameters.Add("@FK_productPriceId", SqlDbType.UniqueIdentifier, 16).Value = model.ProductPriceId;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int, 4).Value = model.Quantity;
                    cmd.Parameters.Add("@total", SqlDbType.Decimal, 9).Value = model.Total;
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit, 1).Value = model.IsActive;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }
    }
}