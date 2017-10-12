using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TeamUp.Models;
using TeamUp.Services;


namespace RepowerProject.Controllers
{
    //[RoutePrefix("api")]
    public class RepowerProjectController : ApiController
    {
        private readonly TeamupService _service;


        public RepowerProjectController()
        {
            _service = new TeamupService();
        }

        //[Route("")]
        public IEnumerable<TeamUpProject> Get()
        {
            return _service.GetProjects();
        }

        // GET: api/RepowerProject
        //[Route("{id}")]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/RepowerProject/5
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST: api/RepowerProject
        //public void Post([FromBody]string value)
        //{
        //}
        public async Task<int> PostAsync([FromBody]TeamUpProject value)
        {
            return await _service.CreateProjectAsync(value);
        }

        // PUT: api/RepowerProject/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RepowerProject/5
        public void Delete(int id)
        {
        }
    }
}
