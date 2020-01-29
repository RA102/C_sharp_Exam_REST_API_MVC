using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class RolesController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: api/Roles
        public IEnumerable<string> Get()
        {
            return new string[] { "value", "value2" };
        }

        // GET: api/Roles/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Roles
        [HttpPost]
        public void CreateRole([FromBody]string role)
        {
            string newRoleName = role.Trim();

            if (!Roles.RoleExists(newRoleName)) {

                Roles.CreateRole(newRoleName);

            }
        }

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
