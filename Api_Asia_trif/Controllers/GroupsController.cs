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
    public class GroupsController : ApiController
    {
        private AsiaDrama_TrifonovaEntities db = new AsiaDrama_TrifonovaEntities();

        // GET: api/Groups
        [ResponseType(typeof(List<GroupsModel>))]
        public IHttpActionResult GetGroups()
        {
            return Ok(db.Groups.ToList().ConvertAll(x => new GroupsModel(x)));
        }

        // GET: api/Groups/5
        [ResponseType(typeof(Groups))]
        public IHttpActionResult GetGroups(int id)
        {
            Groups groups = db.Groups.Find(id);
            if (groups == null)
            {
                return NotFound();
            }

            return Ok(groups);
        }

        // PUT: api/Groups/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGroups(int id, Groups groups)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != groups.IdGroups)
            {
                return BadRequest();
            }

            db.Entry(groups).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupsExists(id))
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

        // POST: api/Groups
        [ResponseType(typeof(Groups))]
        public IHttpActionResult PostGroups(Groups groups)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Groups.Add(groups);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = groups.IdGroups }, groups);
        }

        // DELETE: api/Groups/5
        [ResponseType(typeof(Groups))]
        public IHttpActionResult DeleteGroups(int id)
        {
            Groups groups = db.Groups.Find(id);
            if (groups == null)
            {
                return NotFound();
            }

            db.Groups.Remove(groups);
            db.SaveChanges();

            return Ok(groups);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GroupsExists(int id)
        {
            return db.Groups.Count(e => e.IdGroups == id) > 0;
        }
    }
}