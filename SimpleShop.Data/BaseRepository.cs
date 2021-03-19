using System.Data.SqlClient;
using Microsoft.Extensions.Options;
using SimpleShop.Core.Config;

namespace SimpleShop.Data
{
    public abstract class BaseRepository
    {
        protected SqlConnection _connection;
        protected string _connectionString;
        public BaseRepository(IOptions<AppSettingsConfig> options)
        {
            _connectionString = options.Value.ConnectionString;
        }
    }
}