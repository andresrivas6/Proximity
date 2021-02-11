using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticuloController : ControllerBase
    {
        private readonly ModelDbContext _context;

        public ArticuloController(ModelDbContext context)
        {
            _context = context;
        }


        // GET: api/<ArticuloController>
        [HttpGet]
        public IEnumerable<Articulo> Get()
        {

            return _context.Articulo.ToList();
        }

        // GET api/<ArticuloController>/5
        [HttpGet("{id}")]
        public Articulo Get(int id)
        {
            return _context.Articulo.Find(id);
        }

        // POST api/<ArticuloController>
        [HttpPost]
        //[Route("Nuevo")]
        public ActionResult Nuevo([FromBody] Articulo art)
        {
            try
            {
                _context.Add(art);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Ok();//CreatedAtAction("Get", new { id = cli.id }, cli);
        }

        // PUT api/<ArticuloController>/5
        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] Articulo art)
        {
            try
            {
                if (id != art.id)
                    return BadRequest();

                _context.Entry(art).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return NoContent();
        }

        // DELETE api/<ArticuloController>/5
        [HttpDelete("{id}")]
        public ActionResult<Articulo> Delete(int id)
        {
            var cli = _context.Articulo.Find(id);
            if (cli == null)
            {
                return NotFound();
            }

            _context.Articulo.Remove(cli);
            _context.SaveChanges();

            return cli;
        }
    }
}
