using DemoDDD.ApplicationServices;
using DemoDDD.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoDDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        DemoServices demoServices;
        public PersonController(DemoServices demoServices_)
        {
            demoServices = demoServices_;
        }
        [HttpPost]
        public async Task<IActionResult> AddPerson(CreatePersonCommand createPersonCommand)
        {
            await demoServices.HandleCommandAsync(createPersonCommand);
            return Ok(createPersonCommand);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPerson(Guid id)
        {
            var data=await demoServices.GetPersonAsync(id);
            return Ok(data);
        }
    }
}
