using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Repositories.Entity;
using Repositories.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class ChildRepository : IDataRepository<Child>
    {

        private readonly Icontext context;
        public ChildRepository(Icontext icontext)
        {
            this.context = icontext;
        }

        public async Task<Child> AddDataAsync(Child entity)
        {
            EntityEntry<Child> e = await context.Children.AddAsync(entity);
            await context.SaveChangesAsync();
            return e.Entity;
        }
    }
}
