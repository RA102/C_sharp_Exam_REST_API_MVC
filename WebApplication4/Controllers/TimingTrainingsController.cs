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
    public class TimingTrainingsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/TimingTrainings
        public IQueryable<TimingTraining> GetTimingTrainings()
        {
            var timingTrainings = db.TimingTrainings.Include(g => g.Gym).Include(c => c.Coach).Include(t => t.Type);
            return timingTrainings;
        }

        // GET: api/TimingTrainings/5
        [ResponseType(typeof(TimingTraining))]
        public IHttpActionResult GetTimingTraining(int id)
        {
            TimingTraining timingTraining = db.TimingTrainings.Find(id);
            if (timingTraining == null)
            {
                return NotFound();
            }

            return Ok(timingTraining);
        }

        // PUT: api/TimingTrainings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTimingTraining(int id, TimingTraining timingTraining)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != timingTraining.Id)
            {
                return BadRequest();
            }

            db.Entry(timingTraining).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimingTrainingExists(id))
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

        // POST: api/TimingTrainings
        [ResponseType(typeof(TimingTraining))]
        public IHttpActionResult PostTimingTraining(TimingTraining timingTraining)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TimingTrainings.Add(timingTraining);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = timingTraining.Id }, timingTraining);
        }

        // DELETE: api/TimingTrainings/5
        [ResponseType(typeof(TimingTraining))]
        public IHttpActionResult DeleteTimingTraining(int id)
        {
            TimingTraining timingTraining = db.TimingTrainings.Find(id);
            if (timingTraining == null)
            {
                return NotFound();
            }

            db.TimingTrainings.Remove(timingTraining);
            db.SaveChanges();

            return Ok(timingTraining);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TimingTrainingExists(int id)
        {
            return db.TimingTrainings.Count(e => e.Id == id) > 0;
        }
    }
}