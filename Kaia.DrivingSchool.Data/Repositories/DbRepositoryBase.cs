using Kaia.DrivingSchool.Common;
using NLog;
using System;
using System.Data;
using System.Data.Common;

namespace Kaia.DrivingSchool.Data.Repositories
{
    public abstract class DbRepositoryBase
    {
        protected readonly IClock _clock;
        protected readonly DbProviderFactory _factory;
        protected readonly string _connectionString;
        protected readonly ILogger _logger;

        public DbRepositoryBase(IClock clock, string providerName, string connectionString)
        {
            _logger = LogManager.GetLogger(GetType().FullName);
            _clock = clock;
            try
            {
                _factory = DbProviderFactories.GetFactory(providerName);
            }
            catch (Exception exc)
            {
                _logger.Error(exc, @"Error getting provider factory ""{0}""", providerName);
                _logger.Error("Installed database providers are:");
                foreach (DataRow factory in DbProviderFactories.GetFactoryClasses().Rows)
                {
                    _logger.Error("\t{0}", factory[0]);
                }
                throw;
            }
            _connectionString = connectionString;
        }

        /// <summary>
        /// Creates and opens a connection using the supplied connection string and provider factory
        /// </summary>
        public DbConnection OpenConnection()
        {
            var connection = _factory.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();
            return connection;
        }
    }
}
