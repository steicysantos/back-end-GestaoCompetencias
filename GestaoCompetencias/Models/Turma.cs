using System;
using System.Collections.Generic;

namespace GestaoCompetencias.Models
{
    public partial class Turma
    {
        public Turma()
        {
            Aprendizs = new HashSet<Aprendiz>();
            Materia = new HashSet<Materia>();
            TurmaProfessors = new HashSet<TurmaProfessor>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public DateTime DataDeInicio { get; set; }
        public DateTime DataDeFim { get; set; }

        public virtual ICollection<Aprendiz> Aprendizs { get; set; }
        public virtual ICollection<Materia> Materia { get; set; }
        public virtual ICollection<TurmaProfessor> TurmaProfessors { get; set; }
    }
}
