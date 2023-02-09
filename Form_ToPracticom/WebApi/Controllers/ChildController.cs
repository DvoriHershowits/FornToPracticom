using Common.Dto_s;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Services.Interfase;
using WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
   
    [Route("api/[controller]")]

    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IDataService<ChildDto> dataServices;
        public ChildController(IDataService<ChildDto> dataServices)
        {
            this.dataServices = dataServices;
        }


        
        // POST api/<ChildController>
        [HttpPost]
        public async Task<ChildDto> AddChild([FromBody] ChildModel value)
        {
            ChildDto c = new ChildDto();
            c.IdNumberChild = value.IdNumberChild;
            c.IdParent = value.IdParent;
            c.DateOfBirth = value.DateOfBirth;
            c.Name = value.Name;
           
           return await dataServices.AddDataAsync(c);  
        }

       
    }
}
