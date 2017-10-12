using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TeamUp.Models;
using TeamUp.Services;

namespace TeamUp.Controllers
{
    //[RoutePrefix("api")]
    public class TeamUpController : ApiController
    {
        private readonly TeamupService _services;


        public TeamUpController()
        {
            _services = new TeamupService();
        }

        //[Route("")]
        public IEnumerable<TeamUpProject> Get()
        {
            return _services.GetProjects();
        }

        // GET: api/TeamUp
        //[Route("{id}")]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/TeamUp/5
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST: api/TeamUp
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TeamUp/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TeamUp/5
        public void Delete(int id)
        {
        }
    }
}
