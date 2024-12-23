﻿using Ahi.CustomerService.source.Application.DTOs.Customer;
using Ahi.CustomerService.source.Domain.Infrastructure.Persistence;
using Ahi.CustomerService.source.Domain.Interfaces.Repositories;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Ahi.CustomerService.source.Infrastructure.Persistence
{
    public class CustomerWriteRepository : ICustomerWriteRepository
    {
        public async Task<Guid> AddAsync(CustomerCreateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCustomerInsert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FK_userId", SqlDbType.UniqueIdentifier, 16).Value = model.Id;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 24).Value = model.Name;
                    cmd.Parameters.Add("@surname", SqlDbType.VarChar, 24).Value = model.Surname;
                    cmd.Parameters.Add("@gender", SqlDbType.Bit, 1).Value = model.Gender;
                    cmd.Parameters.Add("@BirthDay", SqlDbType.Date, 3).Value = model.BirthDay;
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
                using (var cmd = new SqlCommand("usp_tblCustomerDelete", con))
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
                using (var cmd = new SqlCommand("usp_tblCustomerDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = id;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }

        public async Task<bool> UpdateAsync(CustomerUpdateDTO model)
        {
            using (var con = Connection.SqlConnection())
            {
                using (var cmd = new SqlCommand("usp_tblCustomerUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 16).Value = model.Id;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 24).Value = model.Name;
                    cmd.Parameters.Add("@surname", SqlDbType.VarChar, 24).Value = model.Surname;
                    cmd.Parameters.Add("@gender", SqlDbType.Bit, 1).Value = model.Gender;
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit, 1).Value = model.IsActive;

                    con.Open();
                    return await cmd.ExecuteNonQueryAsync() != 0;
                }
            }
        }
    }
}
