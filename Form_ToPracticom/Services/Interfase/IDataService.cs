using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfase
{
    public interface IDataService<T>
    {
        Task<T> AddDataAsync(T entity);
    }
}
