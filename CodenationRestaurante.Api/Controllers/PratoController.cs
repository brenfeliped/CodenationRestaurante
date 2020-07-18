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
    public class PratoController : ControllerBase
    {
        private PratoRepositorio _repo;

        public PratoController()
        {
            _repo = new PratoRepositorio();
        }

        // GET: api/<PratoController>
        [HttpGet]
        public IEnumerable<Prato> Get()
        {
            return _repo.RetornarTodos();
        }

        // GET api/<PratoController>/5
        [HttpGet("{id}")]
        public Prato Get(int id)
        {
            
            return _repo.BuscaPorId(id);
        }

        // POST api/<PratoController>
        [HttpPost]
        public IEnumerable<Prato> Post([FromBody] Prato prato)
        {
            _repo.Incluir(prato);
            return _repo.RetornarTodos();
        }

        // PUT api/<PratoController>/5
        [HttpPut("{id}")]
        public IEnumerable<Prato> Put([FromBody] Prato prato)
        {
            _repo.Alterar(prato);

            return _repo.RetornarTodos();
        }

        // DELETE api/<PratoController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Prato> Delete(int id)
        {
            _repo.Excluir(id);

            return _repo.RetornarTodos();
        }
    }
}
