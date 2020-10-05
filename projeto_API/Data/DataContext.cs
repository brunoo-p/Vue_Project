using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using projeto_API.Models;

namespace projeto_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Aluno>()
                .HasData(
                    new List<Aluno>(){
                        new Aluno(){
                            Id = 1,
                            Nome = "Bruno",
                            Sobrenome = "Paulino",
                            DataNasc = "01/02/2003",
                            Contato = "(45) 91234-5678",
                            ProfessorId = 1
                        },

                        new Aluno(){
                            Id = 2,
                            Nome = "João",
                            Sobrenome = "Sem Braço",
                            DataNasc = "22/11/2008",
                            Contato = "(45) 92468-1012",
                            ProfessorId = 3
                        },

                        new Aluno(){
                            Id = 3,
                            Nome = "Maria",
                            Sobrenome = "Das Dores",
                            DataNasc = "21/07/2014",
                            Contato = "(45) 91101-1215",
                            ProfessorId = 2
                        },

                        new Aluno(){
                            Id = 4,
                            Nome = "Zé",
                            Sobrenome = "Benedito",
                            DataNasc = "01/05/1993",
                            Contato = "(45) 98765-4321",
                            ProfessorId = 2
                        }
                    }
                );
            builder.Entity<Professor>()
                .HasData(
                    new List<Professor>(){
                        new Professor(){
                            Id = 1,
                            Nome = "Leda"
                        },

                        new Professor(){
                            Id = 2,
                            Nome = "Roberto",
                        },

                        new Professor(){
                            Id = 3,
                            Nome = "Márcia"
                        }
                    }
                );
        }


    }
}