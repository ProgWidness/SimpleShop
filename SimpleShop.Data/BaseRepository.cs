using System.Data.SqlClient;
using Microsoft.Extensions.Options;
using SimpleShop.Core.Config;

namespace SimpleShop.Data
{
    public abstract class BaseRepository
    {
        protected SqlConnection _connection;
        public BaseRepository(IOptions<AppSettingsConfig> options)
        {
            _connection = new SqlConnection(options.Value.ConnectionString);
        }
    }
}