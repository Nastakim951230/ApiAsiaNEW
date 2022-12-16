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
    public class KinoAndSerialsController : ApiController
    {
        private AsiaDrama_TrifonovaEntities db = new AsiaDrama_TrifonovaEntities();

        // GET: api/KinoAndSerials
        [ResponseType(typeof(List<KinoAndSerialsModel>))]
        public IHttpActionResult GetKinoAndSerial()
        {
            return Ok(db.KinoAndSerial.ToList().ConvertAll(x => new KinoAndSerialsModel(x)));
        }

        // GET: api/KinoAndSerials/5
        [ResponseType(typeof(KinoAndSerial))]
        public IHttpActionResult GetKinoAndSerial(int id)
        {
            KinoAndSerial kinoAndSerial = db.KinoAndSerial.Find(id);
            if (kinoAndSerial == null)
            {
                return NotFound();
            }

            return Ok(kinoAndSerial);
        }

        // PUT: api/KinoAndSerials/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKinoAndSerial(int id, KinoAndSerial kinoAndSerial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kinoAndSerial.IdKinoAndSerial)
            {
                return BadRequest();
            }

            db.Entry(kinoAndSerial).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KinoAndSerialExists(id))
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

        // POST: api/KinoAndSerials
        [ResponseType(typeof(KinoAndSerial))]
        public IHttpActionResult PostKinoAndSerial(KinoAndSerial kinoAndSerial)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.KinoAndSerial.Add(kinoAndSerial);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kinoAndSerial.IdKinoAndSerial }, kinoAndSerial);
        }

        // DELETE: api/KinoAndSerials/5
        [ResponseType(typeof(KinoAndSerial))]
        public IHttpActionResult DeleteKinoAndSerial(int id)
        {
            KinoAndSerial kinoAndSerial = db.KinoAndSerial.Find(id);
            if (kinoAndSerial == null)
            {
                return NotFound();
            }

            db.KinoAndSerial.Remove(kinoAndSerial);
            db.SaveChanges();

            return Ok(kinoAndSerial);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KinoAndSerialExists(int id)
        {
            return db.KinoAndSerial.Count(e => e.IdKinoAndSerial == id) > 0;
        }
    }
}