﻿using Microsoft.Data.SqlClient;

namespace Ahi.CustomerService.source.Domain.Infrastructure.Persistence
{
    static class Connection
    {
        static public string ConnectionString
        {
            get
            {
                return "Server=ABDULLAHYUNUS;Database=Esnaf;Trusted_Connection=True;MultipleActiveResultSets=true";
            }
        }
        static public SqlConnection SqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}