using Esnaf.Application.Repositories;
using Esnaf.Application.DTOs.Customer;
using System.Data.SqlClient;
using System.Data;

namespace Esnaf.Persistence
{
    public class CustomerWriteRepository : ICustomerWriteRepository
    {
        public async Task<bool> AddAsync(CustomerCreate entity)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCustomerInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 24);
                    cmd.Parameters.Add("@surname", SqlDbType.VarChar, 24);
                    cmd.Parameters.Add("@FK_addressId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@gender", SqlDbType.Bit, 1);
                    cmd.Parameters.Add("@BirthDay", SqlDbType.Date, 3);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public bool Delete(Guid id)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCustomerDelete", con))
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
                using (var cmd = new SqlCommand("usp_tblCustomerDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public bool Update(CustomerUpdate entity)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCustomerUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 24);
                    cmd.Parameters.Add("@surname", SqlDbType.VarChar, 24);
                    cmd.Parameters.Add("@FK_addressId", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@gender", SqlDbType.Bit, 1);
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit, 1);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}
