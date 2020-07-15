using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dados;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratoController : ControllerBase
    {
        // GET: api/<PratoController>
        [HttpGet]
        public IEnumerable<Prato> Get()
        {
            using (var contexto = new Contexto()) {

                return contexto.Prato.ToList();
            }
        }

        // GET api/<PratoController>/5
        [HttpGet("{id}")]
        public Prato Get(int id)
        {
            using (var contexto = new Contexto())
            {

                return contexto.Prato.FirstOrDefault(x => x.Id == id);
            }
        }

        // POST api/<PratoController>
        [HttpPost]
        public IEnumerable<Prato> Post([FromBody] Prato prato)
        {
            using (var contexto = new Contexto()) {

                contexto.Prato.Add(prato);
                contexto.SaveChanges();

                return contexto.Prato.ToList();
            }
        }

        // PUT api/<PratoController>/5
        [HttpPut("{id}")]
        public IEnumerable<Prato> Put([FromBody] Prato prato)
        {
            using (var contexto = new Contexto())
            {
                contexto.Prato.Update(prato);
                contexto.SaveChanges();

                return contexto.Prato.ToList();
            }
        }

        // DELETE api/<PratoController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Prato> Delete(int id)
        {
            using (var contexto = new Contexto())
            {

                var entity = contexto.Prato.FirstOrDefault(x => x.Id == id);
                contexto.Prato.Remove(entity);
                contexto.SaveChanges();

                return contexto.Prato.ToList();
            }
        }
    }
}
