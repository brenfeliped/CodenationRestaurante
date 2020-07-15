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
    public class PratosIngredientesController : ControllerBase
    {
        // GET: api/<PratosIngredientesController>
        [HttpGet]
        public IEnumerable<PratosIngredientes> Get()
        {
            using (var contexto = new Contexto())
            {

                return contexto.PratosIngredientes.ToList();
            }
        }

        // GET api/<PratosIngredientesController>/5
        [HttpGet("{id}")]
        public PratosIngredientes Get(int id)
        {
            using (var contexto = new Contexto())
            {

                return contexto.PratosIngredientes.FirstOrDefault(x => x.Id == id);
            }
        }

        // POST api/<PratosIngredientesController>
        [HttpPost]
        public IEnumerable<PratosIngredientes> Post([FromBody] PratosIngredientes pratosIngredientes)
        {
            using (var contexto = new Contexto())
            {

                contexto.PratosIngredientes.Add(pratosIngredientes);
                contexto.SaveChanges();

                return contexto.PratosIngredientes.ToList();
            }
        }

        // PUT api/<PratosIngredientesController>/5
        [HttpPut]
        public IEnumerable<PratosIngredientes> Put( [FromBody] PratosIngredientes pratosIngredientes)
        {
            using (var contexto = new Contexto())
            {
                contexto.PratosIngredientes.Update(pratosIngredientes);
                contexto.SaveChanges();

                return contexto.PratosIngredientes.ToList();
            }
        }

        // DELETE api/<PratosIngredientesController>/5
        [HttpDelete("{id}")]
        public IEnumerable<PratosIngredientes> Delete(int id)
        {
            using (var contexto = new Contexto())
            {

                var entity = contexto.PratosIngredientes.FirstOrDefault(x => x.Id == id);
                contexto.PratosIngredientes.Remove(entity);
                contexto.SaveChanges();

                return contexto.PratosIngredientes.ToList();
            }
        }
    }
}
