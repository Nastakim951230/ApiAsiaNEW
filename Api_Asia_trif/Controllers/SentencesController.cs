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
    public class SentencesController : ApiController
    {
        private AsiaDrama_TrifonovaEntities db = new AsiaDrama_TrifonovaEntities();

        // GET: api/Sentences
        [ResponseType(typeof(List<SentencesModel>))]
        public IHttpActionResult GetSentence()
        {
            return Ok(db.Sentence.ToList().ConvertAll(x => new SentencesModel(x)));
        }

        // GET: api/Sentences/5
        [ResponseType(typeof(Sentence))]
        public IHttpActionResult GetSentence(int id)
        {
            Sentence sentence = db.Sentence.Find(id);
            if (sentence == null)
            {
                return NotFound();
            }

            return Ok(sentence);
        }

        // PUT: api/Sentences/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSentence(int id, Sentence sentence)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sentence.IdSentence)
            {
                return BadRequest();
            }

            db.Entry(sentence).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SentenceExists(id))
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

        // POST: api/Sentences
        [ResponseType(typeof(Sentence))]
        public IHttpActionResult PostSentence(Sentence sentence)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sentence.Add(sentence);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sentence.IdSentence }, sentence);
        }

        // DELETE: api/Sentences/5
        [ResponseType(typeof(Sentence))]
        public IHttpActionResult DeleteSentence(int id)
        {
            Sentence sentence = db.Sentence.Find(id);
            if (sentence == null)
            {
                return NotFound();
            }

            db.Sentence.Remove(sentence);
            db.SaveChanges();

            return Ok(sentence);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SentenceExists(int id)
        {
            return db.Sentence.Count(e => e.IdSentence == id) > 0;
        }
    }
}