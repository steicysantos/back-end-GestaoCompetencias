﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GestaoCompetencias.Models
{
    public partial class DB_Gestao_CompetenciasContext : DbContext
    {
        public DB_Gestao_CompetenciasContext()
        {
        }

        public DB_Gestao_CompetenciasContext(DbContextOptions<DB_Gestao_CompetenciasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aprendiz> Aprendizs { get; set; } = null!;
        public virtual DbSet<AprendizCompetencia> AprendizCompetencias { get; set; } = null!;
        public virtual DbSet<Competencia> Competencias { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<MateriaProfessor> MateriaProfessors { get; set; } = null!;
        public virtual DbSet<Materium> Materia { get; set; } = null!;
        public virtual DbSet<Professor> Professors { get; set; } = null!;
        public virtual DbSet<Turma> Turmas { get; set; } = null!;
        public virtual DbSet<TurmaProfessor> TurmaProfessors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=JVLPC0555\\SQLExpress;Database=DB_Gestao_Competencias;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aprendiz>(entity =>
            {
                entity.ToTable("Aprendiz");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Edv)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TurmaId).HasColumnName("TurmaID");

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.Aprendizs)
                    .HasForeignKey(d => d.LoginId)
                    .HasConstraintName("FK__Aprendiz__LoginI__286302EC");

                entity.HasOne(d => d.Turma)
                    .WithMany(p => p.Aprendizs)
                    .HasForeignKey(d => d.TurmaId)
                    .HasConstraintName("FK__Aprendiz__TurmaI__29572725");
            });

            modelBuilder.Entity<AprendizCompetencia>(entity =>
            {
                entity.ToTable("Aprendiz_Competencias");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AprendizId).HasColumnName("AprendizID");

                entity.Property(e => e.CompetenciasId).HasColumnName("CompetenciasID");

                entity.HasOne(d => d.Aprendiz)
                    .WithMany(p => p.AprendizCompetencia)
                    .HasForeignKey(d => d.AprendizId)
                    .HasConstraintName("FK__Aprendiz___Apren__38996AB5");

                entity.HasOne(d => d.Competencias)
                    .WithMany(p => p.AprendizCompetencia)
                    .HasForeignKey(d => d.CompetenciasId)
                    .HasConstraintName("FK__Aprendiz___Compe__398D8EEE");
            });

            modelBuilder.Entity<Competencia>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(280)
                    .IsUnicode(false);

                entity.Property(e => e.MateriaId).HasColumnName("MateriaID");

                entity.HasOne(d => d.Materia)
                    .WithMany(p => p.Competencia)
                    .HasForeignKey(d => d.MateriaId)
                    .HasConstraintName("FK__Competenc__Mater__35BCFE0A");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Senha)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MateriaProfessor>(entity =>
            {
                entity.ToTable("Materia_Professor");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.MateriaId).HasColumnName("MateriaID");

                entity.Property(e => e.ProfessorId).HasColumnName("ProfessorID");

                entity.HasOne(d => d.Materia)
                    .WithMany(p => p.MateriaProfessors)
                    .HasForeignKey(d => d.MateriaId)
                    .HasConstraintName("FK__Materia_P__Mater__3D5E1FD2");

                entity.HasOne(d => d.Professor)
                    .WithMany(p => p.MateriaProfessors)
                    .HasForeignKey(d => d.ProfessorId)
                    .HasConstraintName("FK__Materia_P__Profe__3C69FB99");
            });

            modelBuilder.Entity<Materium>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DataDeFim).HasColumnType("date");

                entity.Property(e => e.DataDeInicio).HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(280)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TurmaId).HasColumnName("TurmaID");

                entity.HasOne(d => d.Turma)
                    .WithMany(p => p.Materia)
                    .HasForeignKey(d => d.TurmaId)
                    .HasConstraintName("FK__Materia__TurmaID__32E0915F");
            });

            modelBuilder.Entity<Professor>(entity =>
            {
                entity.ToTable("Professor");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Identificador)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.Professors)
                    .HasForeignKey(d => d.LoginId)
                    .HasConstraintName("FK__Professor__Login__2C3393D0");
            });

            modelBuilder.Entity<Turma>(entity =>
            {
                entity.ToTable("Turma");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DataDeFim).HasColumnType("date");

                entity.Property(e => e.DataDeInicio).HasColumnType("date");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TurmaProfessor>(entity =>
            {
                entity.ToTable("Turma_Professor");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ProfessorId).HasColumnName("ProfessorID");

                entity.Property(e => e.TurmaId).HasColumnName("TurmaID");

                entity.HasOne(d => d.Professor)
                    .WithMany(p => p.TurmaProfessors)
                    .HasForeignKey(d => d.ProfessorId)
                    .HasConstraintName("FK__Turma_Pro__Profe__2F10007B");

                entity.HasOne(d => d.Turma)
                    .WithMany(p => p.TurmaProfessors)
                    .HasForeignKey(d => d.TurmaId)
                    .HasConstraintName("FK__Turma_Pro__Turma__300424B4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
