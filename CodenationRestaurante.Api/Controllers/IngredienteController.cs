using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodenationRestaurante.Dominio.Modelo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {
        List<Ingrediente> lst;
        public IngredienteController() {
            lst = new List<Ingrediente>();
            lst.Add( new Ingrediente() {Id=1, Descricao = "Chocolate em barra de 1kg", Nome = "Chocolate", Validade = new DateTime(2020,12,02)});
            lst.Add(new Ingrediente() { Id = 1, Descricao = "Alho triturado em pote sem sal", Nome = "Alho", Validade = new DateTime(2020, 12, 02) });
            lst.Add(new Ingrediente() { Id = 1, Descricao = "Arroz branco de 5 kg", Nome = "Chocolate", Validade = new DateTime(2020, 12, 02) });
        }
        // GET: api/<IngredienteController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<IngredienteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IngredienteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IngredienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IngredienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
