using System;
using System.Collections.Generic;

namespace GestaoCompetencias.Models
{
    public partial class Login
    {
        public Login()
        {
            Aprendizs = new HashSet<Aprendiz>();
            Professors = new HashSet<Professor>();
        }

        public int Id { get; set; }
        public string Usuario { get; set; } = null!;
        public string Senha { get; set; } = null!;

        public virtual ICollection<Aprendiz> Aprendizs { get; set; }
        public virtual ICollection<Professor> Professors { get; set; }
    }
}
