using Npgsql;
using System.Data;

namespace FileDBImport.Worker.Data
{
    public class DapperContext
    {
        private readonly string _connectionString;

        public DapperContext()
        {
            _connectionString = "Host=localhost;Port=5432;Database=Instruments;Username=postgres;Password=12345678";
        }

        public IDbConnection CreateConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }
    }
}
