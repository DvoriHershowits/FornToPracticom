using Common.Dto_s;
using Context;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Repositories.Interfase;
using Services.Interfase;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class CollectionExtensionService
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped <IDataService<ChildDto>, ChildService>();
            services.AddScoped <IDataService<ParentDto>,ParenService>();
            services.AddSingleton<Icontext, SavingFormContext>();
            services.AddAutoMapper(typeof(MappingProfileService));
            return services;


        }
    }
}
