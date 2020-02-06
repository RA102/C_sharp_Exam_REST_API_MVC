using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class GymsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Gyms
        public IQueryable<Gym> GetGyms()
        {
            return db.Gyms;
        }

        // GET: api/Gyms/5
        [ResponseType(typeof(Gym))]
        public IHttpActionResult GetGym(int id)
        {
            Gym gym = db.Gyms.Find(id);
            if (gym == null)
            {
                return NotFound();
            }

            return Ok(gym);
        }

        // PUT: api/Gyms/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGym(int id, Gym gym)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gym.Id)
            {
                return BadRequest();
            }

            db.Entry(gym).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GymExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Gyms
        [ResponseType(typeof(Gym))]
        public IHttpActionResult PostGym(Gym gym)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Gyms.Add(gym);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = gym.Id }, gym);
        }

        // DELETE: api/Gyms/5
        [ResponseType(typeof(Gym))]
        public IHttpActionResult DeleteGym(int id)
        {
            Gym gym = db.Gyms.Find(id);
            if (gym == null)
            {
                return NotFound();
            }

            db.Gyms.Remove(gym);
            db.SaveChanges();

            return Ok(gym);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GymExists(int id)
        {
            return db.Gyms.Count(e => e.Id == id) > 0;
        }
    }
}