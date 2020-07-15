﻿using System;
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
    public class IngredienteController : ControllerBase
    {
        List<Ingrediente> lst;
        public IngredienteController() {
            // lst = new List<Ingrediente>();
            //lst.Add( new Ingrediente() {Id=1, Descricao = "Chocolate em barra de 1kg", Nome = "Chocolate", Validade = new DateTime(2020,12,20)});
            //lst.Add(new Ingrediente() { Id = 2, Descricao = "Alho triturado em pote sem sal", Nome = "Alho", Validade = new DateTime(2020, 12, 20) });
            //lst.Add(new Ingrediente() { Id = 3, Descricao = "Arroz branco de 5 kg", Nome = "Arroz", Validade = new DateTime(2020, 12, 20) });
            //lst.Add(new Ingrediente() { Id = 4, Descricao = "Feijao carioca de 1 kg", Nome = "Feijao", Validade = new DateTime(2020, 12, 20) });
            //lst.Add(new Ingrediente() { Id = 5, Descricao = "Farinha de mandioca", Nome = "Farinha de mandioca", Validade = new DateTime(2020, 12, 20) });
        }
        // GET: api/<Ingrediente>
        [HttpGet]
        public IEnumerable<Ingrediente> Get()
        {
            using (var contexto = new Contexto()) {

                return contexto.Ingrediente.ToList();
            }
            //return lst;
        }

        // GET api/<IngredienteController>/5
        [HttpGet("{id}")]
        public Ingrediente Get(int id)
        {
            using (var contexto = new Contexto()) {

                return contexto.Ingrediente.FirstOrDefault(x => x.Id == id);
            }
            //return lst.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<IngredienteController>
        [HttpPost]
        public IEnumerable<Ingrediente> Post([FromBody] Ingrediente ingrediente)
        {
            // lst.Add(ingrediente);
            // return lst;
            using (var contexto = new Contexto()) {
                contexto.Ingrediente.Add(ingrediente);
                contexto.SaveChanges();

                return contexto.Ingrediente.ToList();
            }
        }

        // PUT api/<IngredienteController>/5
        [HttpPut]
        public IEnumerable<Ingrediente> Put([FromBody] Ingrediente ingrediente)
        {
            // int index = lst.FindIndex(x => x.Id == id);
            // if (index > -1) {
            //    lst[index].Descricao = ingrediente.Descricao;
            //    lst[index].Nome = ingrediente.Nome;
            //     lst[index].Validade = ingrediente.Validade;
            // }

            // return lst;

            using (var contexto = new Contexto()) {
                contexto.Ingrediente.Update(ingrediente);
                contexto.SaveChanges();

                return contexto.Ingrediente.ToList();
            }
        }

        // DELETE api/<IngredienteController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Ingrediente> Delete(int id)
        {
            //var ingrediente = lst.FirstOrDefault(x => x.Id == id);
            //if (ingrediente != null) lst.Remove(ingrediente);
            //return lst;

            using (var contexto = new Contexto()) {

                var entity = contexto.Ingrediente.FirstOrDefault(x => x.Id == id);
                contexto.Ingrediente.Remove(entity);
                contexto.SaveChanges();

                return contexto.Ingrediente.ToList();
            }
        }
    }
}
