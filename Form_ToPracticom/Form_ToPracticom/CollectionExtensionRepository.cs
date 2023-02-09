using Microsoft.Extensions.DependencyInjection;
using Repositories.Entity;
using Repositories.Interfase;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public static class CollectionExtensionRepository
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IDataRepository<Child>, ChildRepository>();
            services.AddScoped<IDataRepository<Parent>, ParentRepository>();
            return services;
        }
    }
}
