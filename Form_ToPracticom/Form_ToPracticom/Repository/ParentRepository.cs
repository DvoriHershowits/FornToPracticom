using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repositories.Entity;
using Repositories.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class ParentRepository : IDataRepository<Parent>
    {
        private readonly Icontext context;
        public ParentRepository(Icontext context)
        {
            this.context = context;
        }

        public async Task<Parent> AddDataAsync(Parent entity)
        {
            EntityEntry<Parent> e = await context.Parents.AddAsync(entity);
            await context.SaveChangesAsync();
            return e.Entity;
        }
    }
}
