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
using Api_Asia_trif.Models;

namespace Api_Asia_trif.Controllers
{
    public class KinoAndGroupsController : ApiController
    {
        private AsiaDrama_TrifonovaEntities db = new AsiaDrama_TrifonovaEntities();

        // GET: api/KinoAndGroups
        [ResponseType(typeof(List<KinoAndGroupsModel>))]
        public IHttpActionResult GetKinoAndGroups()
        {
            return Ok(db.KinoAndGroups.ToList().ConvertAll(x => new KinoAndGroupsModel(x)));
        }

        // GET: api/KinoAndGroups/5
        [ResponseType(typeof(KinoAndGroups))]
        public IHttpActionResult GetKinoAndGroups(int id)
        {
            KinoAndGroups kinoAndGroups = db.KinoAndGroups.Find(id);
            if (kinoAndGroups == null)
            {
                return NotFound();
            }

            return Ok(kinoAndGroups);
        }

        // PUT: api/KinoAndGroups/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKinoAndGroups(int id, KinoAndGroups kinoAndGroups)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kinoAndGroups.IdKinoAndGroups)
            {
                return BadRequest();
            }

            db.Entry(kinoAndGroups).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KinoAndGroupsExists(id))
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

        // POST: api/KinoAndGroups
        [ResponseType(typeof(KinoAndGroups))]
        public IHttpActionResult PostKinoAndGroups(KinoAndGroups kinoAndGroups)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.KinoAndGroups.Add(kinoAndGroups);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kinoAndGroups.IdKinoAndGroups }, kinoAndGroups);
        }

        // DELETE: api/KinoAndGroups/5
        [ResponseType(typeof(KinoAndGroups))]
        public IHttpActionResult DeleteKinoAndGroups(int id)
        {
            KinoAndGroups kinoAndGroups = db.KinoAndGroups.Find(id);
            if (kinoAndGroups == null)
            {
                return NotFound();
            }

            db.KinoAndGroups.Remove(kinoAndGroups);
            db.SaveChanges();

            return Ok(kinoAndGroups);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KinoAndGroupsExists(int id)
        {
            return db.KinoAndGroups.Count(e => e.IdKinoAndGroups == id) > 0;
        }
    }
}