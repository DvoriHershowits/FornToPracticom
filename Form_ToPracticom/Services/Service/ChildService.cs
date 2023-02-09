using AutoMapper;
using Common.Dto_s;
using Repositories.Entity;
using Repositories.Interfase;
using Services.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class ChildService : IDataService<ChildDto>
    {
        private readonly IDataRepository<Child> dataRepository;
        private readonly IMapper mapper;
        public ChildService(IDataRepository<Child> dataRepository, IMapper mapper)
        {
            this.dataRepository = dataRepository;
            this.mapper = mapper;
        }

        public async Task<ChildDto> AddDataAsync(ChildDto entity)
        {
            Child e = mapper.Map<Child>(entity);
            return mapper.Map<ChildDto>(await dataRepository.AddDataAsync(e));
        }
    }
}
