using APIUNI.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace APIUNI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    
    public class PeopleController : ControllerBase
    {
        [Authorize]
        [HttpGet(Name = "Get")]
        public IEnumerable<PersonResponse> Get()
        {
            return null;
        }

        [Authorize(Policy = "RequireAdministratorRole",Roles ="Administrator")]
        [HttpGet(Name = "Get2")]
        public IEnumerable<PersonResponse> Get2()
        {
            return null;
        }
    }
}
