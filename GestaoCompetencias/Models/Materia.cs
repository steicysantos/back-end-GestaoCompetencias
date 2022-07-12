using System;
using System.Collections.Generic;

namespace GestaoCompetencias.Models
{
    public partial class Materium
    {
        public Materium()
        {
            Competencia = new HashSet<Competencia>();
            MateriaProfessors = new HashSet<MateriaProfessor>();
        }

        public int Id { get; set; }
        public int? TurmaId { get; set; }
        public string Nome { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public DateTime DataDeInicio { get; set; }
        public DateTime DataDeFim { get; set; }

        public virtual Turma? Turma { get; set; }
        public virtual ICollection<Competencia> Competencia { get; set; }
        public virtual ICollection<MateriaProfessor> MateriaProfessors { get; set; }
    }
}
