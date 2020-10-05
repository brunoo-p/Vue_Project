﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projeto_API.Data;

namespace projeto_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201005221304_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("projeto_API.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contato")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Contato = "(45) 91234-5678",
                            DataNasc = "01/02/2003",
                            Nome = "Bruno",
                            ProfessorId = 1,
                            Sobrenome = "Paulino"
                        },
                        new
                        {
                            Id = 2,
                            Contato = "(45) 92468-1012",
                            DataNasc = "22/11/2008",
                            Nome = "João",
                            ProfessorId = 3,
                            Sobrenome = "Sem Braço"
                        },
                        new
                        {
                            Id = 3,
                            Contato = "(45) 91101-1215",
                            DataNasc = "21/07/2014",
                            Nome = "Maria",
                            ProfessorId = 2,
                            Sobrenome = "Das Dores"
                        },
                        new
                        {
                            Id = 4,
                            Contato = "(45) 98765-4321",
                            DataNasc = "01/05/1993",
                            Nome = "Zé",
                            ProfessorId = 2,
                            Sobrenome = "Benedito"
                        });
                });

            modelBuilder.Entity("projeto_API.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Leda"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Roberto"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Márcia"
                        });
                });

            modelBuilder.Entity("projeto_API.Models.Aluno", b =>
                {
                    b.HasOne("projeto_API.Models.Professor", "Professor")
                        .WithMany("Alunos")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
