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
using ApiExamen.Models;

namespace ApiExamen.Controllers
{
    public class EmpleadoHabilidadController : ApiController
    {
        private ExamenEntities db = new ExamenEntities();

        // GET: api/EmpleadoHabilidad
        public IQueryable<Empleado_Habilidad> GetEmpleado_Habilidad()
        {
            return db.Empleado_Habilidad;
        }

        // GET: api/EmpleadoHabilidad/5
        [ResponseType(typeof(Empleado_Habilidad))]
        public IHttpActionResult GetEmpleado_Habilidad(int id)
        {
            Empleado_Habilidad empleado_Habilidad = db.Empleado_Habilidad.Find(id);
            if (empleado_Habilidad == null)
            {
                return NotFound();
            }

            return Ok(empleado_Habilidad);
        }

        // PUT: api/EmpleadoHabilidad/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmpleado_Habilidad(int id, Empleado_Habilidad empleado_Habilidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != empleado_Habilidad.IdHabilidad)
            {
                return BadRequest();
            }

            db.Entry(empleado_Habilidad).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Empleado_HabilidadExists(id))
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

        // POST: api/EmpleadoHabilidad
        [ResponseType(typeof(Empleado_Habilidad))]
        public IHttpActionResult PostEmpleado_Habilidad(Empleado_Habilidad empleado_Habilidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Empleado_Habilidad.Add(empleado_Habilidad);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = empleado_Habilidad.IdHabilidad }, empleado_Habilidad);
        }

        // DELETE: api/EmpleadoHabilidad/5
        [ResponseType(typeof(Empleado_Habilidad))]
        public IHttpActionResult DeleteEmpleado_Habilidad(int id)
        {
            Empleado_Habilidad empleado_Habilidad = db.Empleado_Habilidad.Find(id);
            if (empleado_Habilidad == null)
            {
                return NotFound();
            }

            db.Empleado_Habilidad.Remove(empleado_Habilidad);
            db.SaveChanges();

            return Ok(empleado_Habilidad);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Empleado_HabilidadExists(int id)
        {
            return db.Empleado_Habilidad.Count(e => e.IdHabilidad == id) > 0;
        }
    }
}