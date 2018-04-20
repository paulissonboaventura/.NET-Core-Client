using System;
using System.Collections.Generic;

namespace Core.Domain.Models
{
    public partial class Evento
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public bool? Ativo { get; set; }
    }
}
