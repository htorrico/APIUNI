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
            List<PersonResponse> response = new List<PersonResponse>();
            response.Add(new PersonResponse { FirstName = "Hugo", LastName = "Torrico" });
            response.Add(new PersonResponse { FirstName = "Juan", LastName = "Torrico" });
            return response;
        }

        [Authorize(Roles = "Invited" )]
        [HttpGet(Name = "GetInvited")]
        public IEnumerable<PersonResponse> GetInvited()
        {
            List<PersonResponse> response = new List<PersonResponse>();
            response.Add(new PersonResponse { FirstName = "Hugo", LastName = "Torrico" });
            response.Add(new PersonResponse { FirstName = "Juan", LastName = "Torrico" });
            return response;
        }

        [Authorize(Roles ="Administrator")]
        [HttpGet(Name = "GetAdministrator")]
        public IEnumerable<PersonResponse> GetAdministrator()
        {
            List<PersonResponse> response = new List<PersonResponse>();
            response.Add(new PersonResponse { FirstName = "Hugo", LastName = "Torrico" });
            response.Add(new PersonResponse { FirstName = "Juan", LastName = "Torrico" });
            return response;
        }

        [Authorize(Roles = "SuperUser")]
        [HttpGet(Name = "GetSuperUser")]
        public IEnumerable<PersonResponse> GetSuperUser()
        {
            List<PersonResponse> response = new List<PersonResponse>();
            response.Add(new PersonResponse { FirstName = "Hugo", LastName = "Torrico" });
            response.Add(new PersonResponse { FirstName = "Juan", LastName = "Torrico" });
            return response;
        }
    }
}
