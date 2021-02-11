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
    public class ArticulosFacturaController : ControllerBase
    {
        private readonly ModelDbContext _context;

        public ArticulosFacturaController(ModelDbContext context)
        {
            _context = context;
        }


        // GET: api/<ArticulosFacturaController>
        [HttpGet]
        public IEnumerable<ArticulosFactura> Get()
        {

            return _context.ArticulosFactura.ToList();
        }

        // GET api/<ArticulosFacturaController>/5
        [HttpGet("{id}")]
        public ArticulosFactura Get(int id)
        {
            return _context.ArticulosFactura.Find(id);
        }

        // POST api/<ArticulosFacturaController>
        [HttpPost]
        //[Route("Nuevo")]
        public ActionResult Nuevo([FromBody] ArticulosFactura art)
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

        // PUT api/<ArticulosFacturaController>/5
        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] ArticulosFactura art)
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

        // DELETE api/<ArticulosFacturaController>/5
        [HttpDelete("{id}")]
        public ActionResult<ArticulosFactura> Delete(int id)
        {
            var cli = _context.ArticulosFactura.Find(id);
            if (cli == null)
            {
                return NotFound();
            }

            _context.ArticulosFactura.Remove(cli);
            _context.SaveChanges();

            return cli;
        }
    }
}
