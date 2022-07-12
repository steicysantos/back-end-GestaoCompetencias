﻿using System;
using System.Collections.Generic;

namespace GestaoCompetencias.Models
{
    public partial class Competencia
    {
        public Competencia()
        {
            AprendizCompetencia = new HashSet<AprendizCompetencia>();
        }

        public int Id { get; set; }
        public int? MateriaId { get; set; }
        public string Descricao { get; set; } = null!;

        public virtual Materia? Materia { get; set; }
        public virtual ICollection<AprendizCompetencia> AprendizCompetencia { get; set; }
    }
}
