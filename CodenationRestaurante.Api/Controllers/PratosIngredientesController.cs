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
    public class PratosIngredientesController : ControllerBase
    {
        private PratosIngredientessIngredientesRepositorio _repo;
        public PratosIngredientesController()
        {
            _repo = new PratosIngredientessIngredientesRepositorio();
        }


        // GET: api/<PratosIngredientesController>
        [HttpGet]
        public IEnumerable<PratosIngredientes> Get()
        {
            return _repo.RetornarTodos();
        }

        // GET api/<PratosIngredientesController>/5
        [HttpGet("{id}")]
        public PratosIngredientes Get(int id)
        {
            return _repo.BuscaPorId(id);
        }

        // POST api/<PratosIngredientesController>
        [HttpPost]
        public IEnumerable<PratosIngredientes> Post([FromBody] PratosIngredientes pratosIngredientes)
        {
            _repo.Incluir(pratosIngredientes);
            return _repo.RetornarTodos();
        }

        // PUT api/<PratosIngredientesController>/5
        [HttpPut]
        public IEnumerable<PratosIngredientes> Put( [FromBody] PratosIngredientes pratosIngredientes)
        {
            _repo.Alterar(pratosIngredientes);

            return _repo.RetornarTodos();
        }

        // DELETE api/<PratosIngredientesController>/5
        [HttpDelete("{id}")]
        public IEnumerable<PratosIngredientes> Delete(int id)
        {
            _repo.Excluir(id);

            return _repo.RetornarTodos();
        }
    }
}
