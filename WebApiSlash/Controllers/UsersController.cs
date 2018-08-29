using System.Text.RegularExpressions;
using System.Web.Http;

namespace WebApiSlash.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        [HttpGet]
        [Route("{accountName}")]
        public string Get([FromUri] string accountName)
        {
            return accountName.TrimEnd('/');
        }

        [Route("{domainName}/{accountName}")]
        public string Get(string domainName, string accountName)
        {
            return Regex.Unescape($"{domainName}\\{accountName}");
        }
    }
}
