using APIUNI.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace APIUNI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    
    public class PeopleController : ControllerBase
    {
        
        [HttpGet(Name = "Get")]
        public IEnumerable<PersonResponse> Get()
        {
            return null;
        }

        [Authorize]
        [HttpGet(Name = "Get2")]
        public IEnumerable<PersonResponse> Get2()
        {
            return null;
        }

        [Authorize(Roles ="Administrator")]
        [HttpGet(Name = "Get3")]
        public IEnumerable<PersonResponse> Get3()
        {
            return null;
        }

        [Authorize(Roles = "User")]
        [HttpGet(Name = "Get4")]
        public IEnumerable<PersonResponse> Get4()
        {
            return null;
        }
    }
}
