using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dados;
using CodenationRestaurante.Dados.Repositorio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {
        private IngredienteRepositorio _repo;
        public IngredienteController() 
        {

            _repo = new IngredienteRepositorio();
           
        }
        // GET: api/<Ingrediente>
        [HttpGet]
        public IEnumerable<Ingrediente> Get()
        {
            return _repo.RetornarTodos();
        }

        // GET api/<IngredienteController>/5
        [HttpGet("{id}")]
        public Ingrediente Get(int id)
        {
            return _repo.BuscaPorId(id);
        }

        // POST api/<IngredienteController>
        [HttpPost]
        public IEnumerable<Ingrediente> Post([FromBody] Ingrediente ingrediente)
        {
            _repo.Incluir(ingrediente);
            return _repo.RetornarTodos();
        }

        // PUT api/<IngredienteController>/5
        [HttpPut]
        public IEnumerable<Ingrediente> Put([FromBody] Ingrediente ingrediente)
        {
            _repo.Alterar(ingrediente);

            return _repo.RetornarTodos();
        }

        // DELETE api/<IngredienteController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Ingrediente> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.RetornarTodos();
        }
    }
}
