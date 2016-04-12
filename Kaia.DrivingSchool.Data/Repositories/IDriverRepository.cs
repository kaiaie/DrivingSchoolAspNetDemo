using Kaia.DrivingSchool.Data.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaia.DrivingSchool.Data.Repositories
{
    public interface IDriverRepository
    {
        IEnumerable<Driver> SelectAll();

        void Create(Driver item);

        void Update(Driver item);
    }
}
