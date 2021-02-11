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
    public class ClienteController : ControllerBase
    {

        private readonly ModelDbContext _context;

        public ClienteController(ModelDbContext context)
        {
            _context = context;
        }


        // GET: api/<ClienteController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {

            return _context.Cliente.ToList();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return _context.Cliente.Find(id);
        }

        // POST api/<ClienteController>
        [HttpPost]
        //[Route("Nuevo")]
        public ActionResult Nuevo([FromBody] Cliente cli)
        {
            try
            {
                _context.Add(cli);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Ok();//CreatedAtAction("Get", new { id = cli.id }, cli);
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] Cliente cli)
        {
            try
            {
                if (id != cli.id)
                    return BadRequest();

                _context.Entry(cli).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return NoContent();
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public ActionResult<Cliente> Delete(int id)
        {
            var cli = _context.Cliente.Find(id);
            if (cli == null)
            {
                return NotFound();
            }

            _context.Cliente.Remove(cli);
            _context.SaveChanges();

            return cli;
        }
    }
}
