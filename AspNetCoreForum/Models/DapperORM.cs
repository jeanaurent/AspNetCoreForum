using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreForum.Models
{
    public static class DapperORM
    {
        private static string ConnectionString = @"Data Source=localhost;port=5432;Pooling=true;Initial Catalog=ShopDB;User Id= postgres;Password=SunWave2019!;SslMode=none;";
    
        public static void ExecuteWithoutReturn(string procedureName, DynamicParameters param)
        {
            using(NpgsqlConnection sqlCon = new NpgsqlConnection(ConnectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType : CommandType.StoredProcedure);
            }
        }
    }
}
