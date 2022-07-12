using System;
using System.Collections.Generic;

namespace GestaoCompetencias.Models
{
    public partial class Professor
    {
        public Professor()
        {
            MateriaProfessors = new HashSet<MateriaProfessor>();
            TurmaProfessors = new HashSet<TurmaProfessor>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Identificador { get; set; } = null!;
        public int? LoginId { get; set; }
        public bool Interno { get; set; }
        public bool Adm { get; set; }

        public virtual Login? Login { get; set; }
        public virtual ICollection<MateriaProfessor> MateriaProfessors { get; set; }
        public virtual ICollection<TurmaProfessor> TurmaProfessors { get; set; }
    }
}
