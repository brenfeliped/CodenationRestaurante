﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodenationRestaurante.Dominio.Modelo
{
    public class TipoPrato
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public List<Prato> Pratos { get; set; }


    }
}
