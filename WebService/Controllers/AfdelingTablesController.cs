﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebService;

namespace WebService.Controllers
{
    public class AfdelingTablesController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: api/AfdelingTables
        public IQueryable<AfdelingTable> GetAfdelingTable()
        {
            return db.AfdelingTable;
        }

        // GET: api/AfdelingTables/5
        [ResponseType(typeof(AfdelingTable))]
        public IHttpActionResult GetAfdelingTable(int id)
        {
            AfdelingTable afdelingTable = db.AfdelingTable.Find(id);
            if (afdelingTable == null)
            {
                return NotFound();
            }

            return Ok(afdelingTable);
        }

        // PUT: api/AfdelingTables/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAfdelingTable(int id, AfdelingTable afdelingTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != afdelingTable.Id)
            {
                return BadRequest();
            }

            db.Entry(afdelingTable).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AfdelingTableExists(id))
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

        // POST: api/AfdelingTables
        [ResponseType(typeof(AfdelingTable))]
        public IHttpActionResult PostAfdelingTable(AfdelingTable afdelingTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AfdelingTable.Add(afdelingTable);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (AfdelingTableExists(afdelingTable.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = afdelingTable.Id }, afdelingTable);
        }

        // DELETE: api/AfdelingTables/5
        [ResponseType(typeof(AfdelingTable))]
        public IHttpActionResult DeleteAfdelingTable(int id)
        {
            AfdelingTable afdelingTable = db.AfdelingTable.Find(id);
            if (afdelingTable == null)
            {
                return NotFound();
            }

            db.AfdelingTable.Remove(afdelingTable);
            db.SaveChanges();

            return Ok(afdelingTable);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AfdelingTableExists(int id)
        {
            return db.AfdelingTable.Count(e => e.Id == id) > 0;
        }
    }
}