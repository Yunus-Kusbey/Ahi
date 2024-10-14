using Esnaf.Application.Repositories;
using System.Data.SqlClient;
using System.Data;
using Esnaf.Application.DTOs.Address;

namespace Esnaf.Persistence.Repositories
{
    public class AddressWriteRepository : IAddressWriteRepository
    {
        public async Task<bool> AddAsync(AddressCreate model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblAddressInsert",con))
                {
                    cmd.CommandType =CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FK_customerId", SqlDbType.UniqueIdentifier, 16).Value=model.CustomerId;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 20).Value=model.Name;
                    cmd.Parameters.Add("@FK_province", SqlDbType.Char, 2).Value=model.ProvinceId;
                    cmd.Parameters.Add("@FK_county", SqlDbType.Char, 4).Value=model.CountyId;
                    cmd.Parameters.Add("@openAddress", SqlDbType.VarChar, 50).Value=model.OpenAddress;

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
                using (var cmd = new SqlCommand("usp_tblAddressDelete",con))
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
                using (var cmd = new SqlCommand("usp_tblAddressDelete",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public bool Update(AddressUpdate model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblAddressUpdate",con))
                {
                    cmd.CommandType= CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 20);
                    cmd.Parameters.Add("@FK_province", SqlDbType.Char, 2);
                    cmd.Parameters.Add("@FK_county", SqlDbType.Char, 4);
                    cmd.Parameters.Add("@openAddress", SqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit, 1);

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
        }
    }
}