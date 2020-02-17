using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using webApiRestRoc.Models;

namespace webApiRestRoc.Controllers
{
    public class HistorialTController : ApiController
    {
        private DataProductsEntities db = new DataProductsEntities();

        // GET: api/HistorialT
        public IQueryable<HistorialT> GetHistorialTs()
        {
            return db.HistorialTs;
        }

        // GET: api/HistorialT/5
        [ResponseType(typeof(HistorialT))]
        public async Task<IHttpActionResult> GetHistorialT(int id)
        {
            HistorialT historialT = await db.HistorialTs.FindAsync(id);
            if (historialT == null)
            {
                return NotFound();
            }

            return Ok(historialT);
        }

        // PUT: api/HistorialT/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutHistorialT(int id, HistorialT historialT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != historialT.id)
            {
                return BadRequest();
            }

            db.Entry(historialT).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistorialTExists(id))
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

        // POST: api/HistorialT
        [ResponseType(typeof(HistorialT))]
        public async Task<IHttpActionResult> PostHistorialT(HistorialT historialT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HistorialTs.Add(historialT);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = historialT.id }, historialT);
        }

        // DELETE: api/HistorialT/5
        [ResponseType(typeof(HistorialT))]
        public async Task<IHttpActionResult> DeleteHistorialT(int id)
        {
            HistorialT historialT = await db.HistorialTs.FindAsync(id);
            if (historialT == null)
            {
                return NotFound();
            }

            db.HistorialTs.Remove(historialT);
            await db.SaveChangesAsync();

            return Ok(historialT);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HistorialTExists(int id)
        {
            return db.HistorialTs.Count(e => e.id == id) > 0;
        }
    }
}