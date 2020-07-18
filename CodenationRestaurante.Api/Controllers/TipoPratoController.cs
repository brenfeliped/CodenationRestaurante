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
    public class TipoPratoController : ControllerBase
    {
        private TipoPratoRepositorio _repo;
        public TipoPratoController()
        {
            _repo = new TipoPratoRepositorio();
        }

        // GET: api/<TipoPratoController>
        [HttpGet]
        public IEnumerable<TipoPrato> Get()
        {
            return _repo.RetornarTodos();
        }

        // GET api/<TipoPratoController>/5
        [HttpGet("{id}")]
        public TipoPrato Get(int id)
        {
            return _repo.BuscaPorId(id);
           
        }

        // POST api/<TipoPratoController>
        [HttpPost]
        public IEnumerable<TipoPrato> Post([FromBody] TipoPrato tipoPrato)
        {
            _repo.Incluir(tipoPrato);
            return _repo.RetornarTodos();
        }

        // PUT api/<TipoPratoController>/5
        [HttpPut]
        public IEnumerable<TipoPrato> Put([FromBody] TipoPrato tipoPrato)
        {
            _repo.Alterar(tipoPrato);

            return _repo.RetornarTodos();
        }

        // DELETE api/<TipoPratoController>/5
        [HttpDelete("{id}")]
        public IEnumerable<TipoPrato> Delete(int id)
        {
            _repo.Excluir(id);

            return _repo.RetornarTodos();
        }
    }
}
