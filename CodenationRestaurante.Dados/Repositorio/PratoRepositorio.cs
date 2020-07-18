using CodenationRestaurante.Dominio.Modelo;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CodenationRestaurante.Dados.Repositorio
{
    public class PratoRepositorio
    {
        public List<Prato> RetornarTodos()
        {

            using (var contexto = new Contexto())
            {

                return contexto.Prato.ToList();
            }
        }

        public Prato BuscaPorId(int id)
        {

            using (var contexto = new Contexto())
            {

                return contexto.Prato.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Incluir(Prato Prato)
        {
            using (var contexto = new Contexto())
            {
                contexto.Prato.Add(Prato);
                contexto.SaveChanges();
            }
        }

        public void Alterar(Prato Prato)
        {

            using (var contexto = new Contexto())
            {
                contexto.Prato.Update(Prato);
                contexto.SaveChanges();

            }

        }

        public void Excluir(int id)
        {

            using (var contexto = new Contexto())
            {

                var entity = contexto.Prato.FirstOrDefault(x => x.Id == id);
                contexto.Prato.Remove(entity);
                contexto.SaveChanges();

            }
        }
    }
}
