using System.Web.Http;

namespace WebApiSlash.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/<controller>/5
        public string Get(int id)
        {
            return id.ToString();
        }
    }
}
