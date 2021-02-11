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
    public class FacturaController : ControllerBase
    {
        private readonly ModelDbContext _context;

        public FacturaController(ModelDbContext context)
        {
            _context = context;
        }


        // GET: api/<FacturaController>
        [HttpGet]
        public async Task<IEnumerable<Factura>> Get()
        {

            return await _context.Factura.ToListAsync();
        }

        // GET api/<FacturaController>/5
        [HttpGet("{id}")]
        public Factura Get(int id)
        {
            return _context.Factura.Find(id);
        }

        // POST api/<FacturaController>
        [HttpPost]
        //[Route("Nuevo")]
        public ActionResult Nuevo([FromBody] Factura art)
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

        // PUT api/<FacturaController>/5
        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] Factura art)
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

        // DELETE api/<FacturaController>/5
        [HttpDelete("{id}")]
        public ActionResult<Factura> Delete(int id)
        {
            var cli = _context.Factura.Find(id);
            if (cli == null)
            {
                return NotFound();
            }

            _context.Factura.Remove(cli);
            _context.SaveChanges();

            return cli;
        }
    }
}
