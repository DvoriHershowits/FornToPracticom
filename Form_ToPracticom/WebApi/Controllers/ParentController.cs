using Common.Dto_s;
using Microsoft.AspNetCore.Mvc;
using Services.Interfase;
using WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{

[Route("api/[controller]")]
[ApiController]
    public class ParentController : ControllerBase
    {
        private readonly IDataService<ParentDto> dataServices;
        public ParentController(IDataService<ParentDto> dataServices)
        {
            this.dataServices = dataServices;
        }

        // POST api/<ParentController>
        [HttpPost]
        public async Task<ParentDto> AddParent([FromBody] ParentModel value)
        {
            ParentDto p = new ParentDto();
            p.IdNumberParent = value.IdNumberParent;
            p.FirstName = value.FirstName;
            p.LastName = value.LastName;
            p.DateOfBirth = value.DateOfBirth;
            p.Hmo = value.Hmo;
            p.MaleOrFemale = value.MaleOrFemale;

           return await dataServices.AddDataAsync(p);          

        }

    }
}
