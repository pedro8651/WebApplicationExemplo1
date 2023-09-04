﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationExemplo1.Data;

#nullable disable

namespace WebApplicationExemplo1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230904192218_v105")]
    partial class v105
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplicationExemplo1.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("turmaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("turmaId");

                    b.ToTable("aluno");
                });

            modelBuilder.Entity("WebApplicationExemplo1.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataFechamento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("turma");
                });

            modelBuilder.Entity("WebApplicationExemplo1.Models.Aluno", b =>
                {
                    b.HasOne("WebApplicationExemplo1.Models.Turma", "turma")
                        .WithMany("alunos")
                        .HasForeignKey("turmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("turma");
                });

            modelBuilder.Entity("WebApplicationExemplo1.Models.Turma", b =>
                {
                    b.Navigation("alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
