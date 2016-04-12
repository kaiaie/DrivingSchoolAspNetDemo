using System;
using System.Collections.Generic;
using Dapper;
using Kaia.DrivingSchool.Data.DataObjects;
using Kaia.DrivingSchool.Common;

namespace Kaia.DrivingSchool.Data.Repositories
{
    public class DbDriverRepository : DbRepositoryBase, IDriverRepository
    {
        public DbDriverRepository(IClock clock, string providerName, string connectionString):
            base(clock, providerName, connectionString) { }

        public void Create(Driver item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Driver> SelectAll()
        {
            return OpenConnection().Query<Driver>(@"
                SELECT LastName, FirstName
                FROM Drivers;
            ").AsList();
        }

        public void Update(Driver item)
        {
            throw new NotImplementedException();
        }
    }
}
