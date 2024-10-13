using Esnaf.Domain.Entities;
using Esnaf.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Esnaf.Persistence.Repositories
{
    public class AddressWriteRepository : IAddressWriteRepository
    {
        SqlCommand _command = new();
        public async Task<bool> AddAsync(Address entity)
        {
            using (Connection.SqlConnection())
            {
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "usp_tblAddressInsert";

                _command.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);
                _command.Parameters.Add("@FK_customerId", SqlDbType.UniqueIdentifier, 16);
                _command.Parameters.Add("@name", SqlDbType.VarChar, 20);
                _command.Parameters.Add("@FK_province", SqlDbType.Char, 2);
                _command.Parameters.Add("@FK_county", SqlDbType.Char, 4);
                _command.Parameters.Add("@openAddress", SqlDbType.VarChar, 50);
                _command.Parameters.Add("@isActive", SqlDbType.Bit, 1);

                if (Connection.SqlConnection().State != System.Data.ConnectionState.Open)
                    Connection.Open();
                if (await _command.ExecuteNonQueryAsync() != 0)
                    return true;
                else return false;
            }
        }


        public bool Delete(Address id)
        {

            using (Connection.SqlConnection())
            {
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "usp_tblAddressDelete";

                _command.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);

                if (Connection.SqlConnection().State != System.Data.ConnectionState.Open)
                    Connection.Open();
                if (_command.ExecuteNonQuery() != 0)
                    return true;
                else return false;
            }
        }
        public async Task<bool> DeleteAsync(Address id)
        {
            using (Connection.SqlConnection())
            {
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "usp_tblAddressDelete";

                _command.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);

                if (Connection.SqlConnection().State != System.Data.ConnectionState.Open)
                    Connection.Open();
                if (await _command.ExecuteNonQueryAsync() != 0)
                    return true;
                else return false;
            }
        }

        public bool Update(Address entity)
        {
            using (Connection.SqlConnection())
            {
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "usp_tblAddressUpdate";

                _command.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16);
                _command.Parameters.Add("@FK_customerId", SqlDbType.UniqueIdentifier, 16);
                _command.Parameters.Add("@name", SqlDbType.VarChar, 20);
                _command.Parameters.Add("@FK_province", SqlDbType.Char, 2);
                _command.Parameters.Add("@FK_county", SqlDbType.Char, 4);
                _command.Parameters.Add("@openAddress", SqlDbType.VarChar, 50);
                _command.Parameters.Add("@isActive", SqlDbType.Bit, 1);

                if (Connection.SqlConnection().State != System.Data.ConnectionState.Open)
                    Connection.Open();
                if (_command.ExecuteNonQuery() != 0)
                    return true;
                else return false;


            }
        }
    }
}