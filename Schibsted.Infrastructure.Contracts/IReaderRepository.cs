using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schibsted.Infrastructure.Contracts
{
    public interface IReaderRepository<T> where T: class
    {
        T GetById(object id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByFilter(Func<T, bool> filter);
    }
}
