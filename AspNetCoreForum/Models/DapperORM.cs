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
        private static string ConnectionString = @"User ID=postgres;Password=SunWave2019!;Host=localhost;Port=5432;Database=AspForumDB;Pooling=true;";
        public static void ExecuteWithoutReturn(string procedureName, DynamicParameters param = null)
        {
            using(NpgsqlConnection sqlCon = new NpgsqlConnection(ConnectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType : CommandType.StoredProcedure);
            }
        }

        public static T ExecuteReturnScalar<T>(string procedureName, DynamicParameters param = null)
        {
            using (NpgsqlConnection sqlCon = new NpgsqlConnection(ConnectionString))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.Execute(procedureName, param, commandType: CommandType.StoredProcedure),typeof(T));
            }
        }

        public static IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters param = null)
        {
            try
            {
                //string sql3 = @"messageallw";

                using (NpgsqlConnection sqlCon = new NpgsqlConnection(ConnectionString))
                {
                    
                    sqlCon.Open();
                   return sqlCon.Query<T>("messageallw", param, commandType: CommandType.StoredProcedure);

                  //  NpgsqlCommand pgcom = new NpgsqlCommand(sql3, sqlCon);
                 //   pgcom.CommandType = CommandType.StoredProcedure;
                   // pgcom.Parameters.AddWithValue(":pEmail", "myemail@hotmail.com");
                  //  pgcom.Parameters.AddWithValue(":pPassword", "eikaylie78");
                  //  NpgsqlDataReader pgreader = pgcom.ExecuteReader();
                  //  return null;
                }
            }
            catch (Exception Ex) {
                Console.WriteLine(Ex.Message);
                return null;
            }
        }
    }
}
