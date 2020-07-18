using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CodenationRestaurante.Dominio.Modelo;

namespace CodenationRestaurante.Dados.Repositorio
{
    public class TipoPratoRepositorio
    {
        public List<TipoPrato> RetornarTodos()
        {

            using (var contexto = new Contexto())
            {

                return contexto.TipoPrato.ToList();
            }
        }

        public TipoPrato BuscaPorId(int id)
        {

            using (var contexto = new Contexto())
            {

                return contexto.TipoPrato.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Incluir(TipoPrato TipoPrato)
        {
            using (var contexto = new Contexto())
            {
                contexto.TipoPrato.Add(TipoPrato);
                contexto.SaveChanges();
            }
        }

        public void Alterar(TipoPrato TipoPrato)
        {

            using (var contexto = new Contexto())
            {
                contexto.TipoPrato.Update(TipoPrato);
                contexto.SaveChanges();

            }

        }

        public void Excluir(int id)
        {

            using (var contexto = new Contexto())
            {

                var entity = contexto.TipoPrato.FirstOrDefault(x => x.Id == id);
                contexto.TipoPrato.Remove(entity);
                contexto.SaveChanges();

            }
        }
    }
}
