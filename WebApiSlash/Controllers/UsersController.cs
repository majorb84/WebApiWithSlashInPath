using System;
using System.Text.RegularExpressions;
using System.Web.Http;

namespace WebApiSlash.Controllers
{
    [RoutePrefix("api")]
    public class UsersController : ApiController
    {
        [HttpGet]
        [Route("{accountName}")]
        public string Get([FromUri] string accountName)
        {
            return Uri.UnescapeDataString(accountName.TrimEnd('/'));
        }

        [Route("users/{property}/{id}")]
        [Route("applications/{id}/{property}")]
        public string Get(string id, string property)
        {
            return Uri.UnescapeDataString(id.TrimEnd('/'));
        }

    }
}
