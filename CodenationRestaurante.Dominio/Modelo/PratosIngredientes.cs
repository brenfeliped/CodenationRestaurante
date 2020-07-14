using System;
using System.Collections.Generic;
using System.Text;

namespace CodenationRestaurante.Dominio.Modelo
{
     public class PratosIngredientes
    {
        public int IdPrato { get; set; }
        public Prato Prato { get; set; }

        public int IdIngrediente { get; set; }
        public Ingrediente Ingrediente { get; set; }
        public int Id { get; set; }
    }
}
