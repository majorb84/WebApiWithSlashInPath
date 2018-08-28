using System.Web.Http;

namespace WebApiSlash.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        [HttpGet]
        [Route("{*accountName}")]
        public string Get(string accountName)
        {
            return accountName;
        }
    }
}
