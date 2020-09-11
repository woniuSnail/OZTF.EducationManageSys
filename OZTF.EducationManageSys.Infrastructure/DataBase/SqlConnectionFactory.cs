using MySql.Data.MySqlClient;
using OZTF.EducationManageSys.Application.Configuration.Data;
using System;
using System.Data;

namespace OZTF.EducationManageSys.Infrastructure.DataBase
{
    public class SqlConnectionFactory : ISqlConnectionFactory, IDisposable
    {
        private readonly string _connStr;
        private IDbConnection _dbConnection;

        public SqlConnectionFactory(string connStr)
        {
            _connStr = connStr;
        }

        public IDbConnection GetOpenConnection()
        {
            if(_dbConnection == null || _dbConnection.State != ConnectionState.Open)
            {
                _dbConnection = new MySqlConnection(_connStr);
                _dbConnection.Open();
            }
            return _dbConnection;
        }

        public void Dispose()
        {
            if(_dbConnection != null && _dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
        }
    }
}
