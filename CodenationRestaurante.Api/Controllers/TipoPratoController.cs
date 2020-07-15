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
    public class TipoPratoController : ControllerBase
    {
        // GET: api/<TipoPratoController>
        [HttpGet]
        public IEnumerable<TipoPrato> Get()
        {
            using (var contexto = new Contexto())
            {

                return contexto.TipoPrato.ToList();
            }
        }

        // GET api/<TipoPratoController>/5
        [HttpGet("{id}")]
        public TipoPrato Get(int id)
        {
            using (var contexto = new Contexto())
            {

                return contexto.TipoPrato.FirstOrDefault(x => x.Id == id);
            }
        }

        // POST api/<TipoPratoController>
        [HttpPost]
        public IEnumerable<TipoPrato> Post([FromBody] TipoPrato tipoPrato)
        {
            using (var contexto = new Contexto())
            {

                contexto.TipoPrato.Add(tipoPrato);
                contexto.SaveChanges();

                return contexto.TipoPrato.ToList();
            }
        }

        // PUT api/<TipoPratoController>/5
        [HttpPut]
        public IEnumerable<TipoPrato> Put([FromBody] TipoPrato tipoPrato)
        {
            using (var contexto = new Contexto())
            {
                contexto.TipoPrato.Update(tipoPrato);
                contexto.SaveChanges();

                return contexto.TipoPrato.ToList();
            }
        }

        // DELETE api/<TipoPratoController>/5
        [HttpDelete("{id}")]
        public IEnumerable<TipoPrato> Delete(int id)
        {
            using (var contexto = new Contexto())
            {

                var entity = contexto.TipoPrato.FirstOrDefault(x => x.Id == id);
                contexto.TipoPrato.Remove(entity);
                contexto.SaveChanges();

                return contexto.TipoPrato.ToList();
            }
        }
    }
}
