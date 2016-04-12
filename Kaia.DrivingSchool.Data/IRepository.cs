using System.Collections.Generic;

namespace Kaia.DrivingSchool.Data
{
    public interface IRepository<T>
    {
        IEnumerable<T> SelectAll();

        void Create(T item);

        void Update(T item);
    }
}
