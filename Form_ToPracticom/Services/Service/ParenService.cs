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
    public class ParenService : IDataService<ParentDto>
    {
        private readonly IDataRepository<Parent> dataRepository;
        private readonly IMapper mapper;
        public ParenService(IDataRepository<Parent> dataRepository, IMapper mapper)
        {
            this.dataRepository = dataRepository;
            this.mapper = mapper;
        }

        public async Task<ParentDto> AddDataAsync(ParentDto entity)
        {
           Parent e = mapper.Map<Parent>(entity);
            return mapper.Map<ParentDto>(await dataRepository.AddDataAsync(e));
        }
    }
}
