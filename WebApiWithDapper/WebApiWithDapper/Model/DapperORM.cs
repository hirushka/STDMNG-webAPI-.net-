using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace WebApiWithDapper.Model
{
    public static class DapperORM
    {
        //private static IConfiguration Configuration { get; set; }

       /* private DapperORM(IConfiguration configuration)
        {
            Configuration = configuration;
        }*/

        private static readonly string  connectionString = "Data Source= HIRUSHKAN-DTP\\MSSQLSERVER17; Initial Catalog=students; Integrated Security=False; User Id=sa; Password=abcd@1234;MultipleActiveResultSets=True";
        //Configuration.GetConnectionString("DevConnection");
        //"Data Source= HIRUSHKAN-DTP\\MSSQLSERVER17; Initial Catalog=students; Integrated Security=False; User Id=sa; Password=abcd@1234;MultipleActiveResultSets=True";
        public static async Task<int> ExecuteWithoutReturnAsync(string procedureName, DynamicParameters param)
        {
            using (SqlConnection sqlcon =  new SqlConnection(connectionString))
            {
                sqlcon.Open();
                return await sqlcon.ExecuteAsync(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }

        public static async Task<T> ExecuteReturnScalarAsync<T> (string procedureName, DynamicParameters param)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
               return (T)Convert.ChangeType(await sqlcon.ExecuteScalarAsync(procedureName, param, commandType: CommandType.StoredProcedure), typeof(T));
            }
        }

        public static async Task<IEnumerable<T>> ReturnListAsync<T>(string procedureName, DynamicParameters param)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                return await sqlcon.QueryAsync<T>(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }

        public static async Task<T> ReturnObjectAsync<T>(string procedureName, DynamicParameters param)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                return await sqlcon.QueryFirstOrDefaultAsync<T>(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }
    }

}
