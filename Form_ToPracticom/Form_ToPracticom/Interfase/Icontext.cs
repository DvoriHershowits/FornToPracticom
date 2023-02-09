using Microsoft.EntityFrameworkCore;
using Repositories.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfase
{
    public interface Icontext
    {
        public  DbSet<Child> Children { get; set; }

        public  DbSet<Parent> Parents { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

    }
}
