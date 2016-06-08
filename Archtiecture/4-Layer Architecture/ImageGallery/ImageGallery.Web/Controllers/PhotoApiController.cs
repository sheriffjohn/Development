using System.Collections.Generic;
using System.Web.Http;

namespace ImageGallery.Web.Controllers
{
    public class PhotoApiController : ApiController
    {
        // GET: api/PhotoApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PhotoApi/5        
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PhotoApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PhotoApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PhotoApi/5
        public void Delete(int id)
        {
        }
    }
}
