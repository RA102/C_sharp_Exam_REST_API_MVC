using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;
using System.Web.Security;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class RolesController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Roles
        public IHttpActionResult Get()
        {

            //var roleStore = new RoleStore<IdentityRole>(db);
            string[] roles = Roles.GetAllRoles();
            //var roleMngr = new RoleManager<IdentityRole>(roleStore);

            //var roles = roleMngr.Roles.ToList();

            return Ok(roles);
        }


        // GET: api/Roles/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Roles

        //public async Task<ActionResult<IEnumerable<RoleManager>>>([FromBody]string role)
        //{
            
        //}

        // PUT: api/Roles/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Roles/5
        [HttpDelete]
        public void DeleteRole(int id)
        {
        }
    }
}
