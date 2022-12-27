using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace WS.WebUI.Library.DataAccess
{
    public class SQLDataAccess : ISQLDataAccess
    {
        private readonly IConfiguration _config;

        public SQLDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters, string database = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(database));

            return (await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure)).ToList();
        }

        public async Task SaveDataAsync<T>(string storedProcedure, T parameters, string datavse = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(datavse));

            await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
