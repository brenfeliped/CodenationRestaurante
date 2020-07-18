using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CodenationRestaurante.Dominio.Modelo;

namespace CodenationRestaurante.Dados.Repositorio
{
    public class PratosIngredientessIngredientesRepositorio
    {
        public List<PratosIngredientes> RetornarTodos()
        {

            using (var contexto = new Contexto())
            {

                return contexto.PratosIngredientes.ToList();
            }
        }

        public PratosIngredientes BuscaPorId(int id)
        {

            using (var contexto = new Contexto())
            {

                return contexto.PratosIngredientes.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Incluir(PratosIngredientes PratosIngredientes)
        {
            using (var contexto = new Contexto())
            {
                contexto.PratosIngredientes.Add(PratosIngredientes);
                contexto.SaveChanges();
            }
        }

        public void Alterar(PratosIngredientes PratosIngredientes)
        {

            using (var contexto = new Contexto())
            {
                contexto.PratosIngredientes.Update(PratosIngredientes);
                contexto.SaveChanges();

            }

        }

        public void Excluir(int id)
        {

            using (var contexto = new Contexto())
            {

                var entity = contexto.PratosIngredientes.FirstOrDefault(x => x.Id == id);
                contexto.PratosIngredientes.Remove(entity);
                contexto.SaveChanges();

            }
        }
    }
}
