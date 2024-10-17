using Esnaf.Application.Repositories;
using Esnaf.Application.DTOs.Order;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace Esnaf.Persistence.Repositories
{
    public class OrderWriteRepository : IOrderWriteRepository
    {
        public async Task<Guid> AddAsync(OrderCreateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblOrderInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FK_customerId", SqlDbType.UniqueIdentifier, 16).Value = model.CustomerId;
                    cmd.Parameters.Add("@FK_paymentId", SqlDbType.Char, 1).Value = model.PaymentId;
                    cmd.Parameters.Add("@total", SqlDbType.Decimal, 9).Value = model.Total;
                    cmd.Parameters.Add("@FK_sellerId", SqlDbType.UniqueIdentifier, 16).Value = model.SellerId;
                    cmd.Parameters.Add("@FK_status", SqlDbType.Char, 1).Value = model.Status;
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
                using (var cmd = new SqlCommand("usp_tblOrderDelete", con))
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
                using (var cmd = new SqlCommand("usp_tblOrderDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = id;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public bool Update(OrderUpdateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblOrderUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = model.Id;
                    cmd.Parameters.Add("@FK_customerId", SqlDbType.UniqueIdentifier, 16).Value = model.CustomerId;
                    cmd.Parameters.Add("@FK_paymentId", SqlDbType.Char, 1).Value = model.PaymentId;
                    cmd.Parameters.Add("@total", SqlDbType.Decimal, 9).Value = model.Total;
                    cmd.Parameters.Add("@FK_sellerId", SqlDbType.UniqueIdentifier, 16).Value = model.SellerId;
                    cmd.Parameters.Add("@FK_status", SqlDbType.Char, 1).Value = model.Status;
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit, 1).Value = model.IsActive;

                    con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}
