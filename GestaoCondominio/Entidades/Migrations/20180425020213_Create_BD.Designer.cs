﻿// <auto-generated />
using Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Entidades.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20180425020213_Create_BD")]
    partial class Create_BD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("Entidades.Models.Apartamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apto");

                    b.Property<string>("Situacao");

                    b.HasKey("Id");

                    b.ToTable("Apartamentos");
                });

            modelBuilder.Entity("Entidades.Models.ApartamentoCondominio", b =>
                {
                    b.Property<int>("ApartamentoId");

                    b.Property<int>("CondominioId");

                    b.HasKey("ApartamentoId", "CondominioId");

                    b.HasIndex("CondominioId");

                    b.ToTable("ApartamentoCondominios");
                });

            modelBuilder.Entity("Entidades.Models.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EstadoId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("Entidades.Models.Condominio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("CNPJ");

                    b.Property<int>("CidadeId");

                    b.Property<string>("Endereco");

                    b.Property<int>("EstadoId");

                    b.Property<string>("Nome");

                    b.Property<int>("NumAptos");

                    b.Property<int?>("SindicoId");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("SindicoId")
                        .IsUnique();

                    b.ToTable("Condominios");
                });

            modelBuilder.Entity("Entidades.Models.ContaMorador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataPagamento");

                    b.Property<DateTime>("DataVencimento");

                    b.Property<decimal>("Juros");

                    b.Property<int>("MoradorId");

                    b.Property<decimal>("Valor");

                    b.Property<decimal>("ValorTotal");

                    b.HasKey("Id");

                    b.HasIndex("MoradorId");

                    b.ToTable("ContaMoradores");
                });

            modelBuilder.Entity("Entidades.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("UF");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Entidades.Models.Morador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApartamentoId");

                    b.Property<string>("CPF");

                    b.Property<int>("CondominioId");

                    b.Property<string>("Fone");

                    b.Property<string>("Nome");

                    b.Property<int?>("SindicoId");

                    b.HasKey("Id");

                    b.HasIndex("ApartamentoId");

                    b.HasIndex("CondominioId");

                    b.HasIndex("SindicoId")
                        .IsUnique();

                    b.ToTable("Moradores");
                });

            modelBuilder.Entity("Entidades.Models.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<decimal>("Rateio");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("Entidades.Models.ServicoCondominio", b =>
                {
                    b.Property<int>("ServicoId");

                    b.Property<int>("CondominioId");

                    b.HasKey("ServicoId", "CondominioId");

                    b.HasIndex("CondominioId");

                    b.ToTable("ServicoCondominios");
                });

            modelBuilder.Entity("Entidades.Models.Sindico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Sindicos");
                });

            modelBuilder.Entity("Entidades.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Entidades.Models.ApartamentoCondominio", b =>
                {
                    b.HasOne("Entidades.Models.Apartamento", "Apartamento")
                        .WithMany("ApartamentoCondominios")
                        .HasForeignKey("ApartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entidades.Models.Condominio", "Condominio")
                        .WithMany("ApartamentoCondominios")
                        .HasForeignKey("CondominioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entidades.Models.Cidade", b =>
                {
                    b.HasOne("Entidades.Models.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entidades.Models.Condominio", b =>
                {
                    b.HasOne("Entidades.Models.Cidade", "Cidade")
                        .WithMany("Condominios")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entidades.Models.Estado", "Estado")
                        .WithMany("Condominios")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entidades.Models.Sindico", "Sindico")
                        .WithOne("Condominio")
                        .HasForeignKey("Entidades.Models.Condominio", "SindicoId");
                });

            modelBuilder.Entity("Entidades.Models.ContaMorador", b =>
                {
                    b.HasOne("Entidades.Models.Morador", "Morador")
                        .WithMany("ContaMoradores")
                        .HasForeignKey("MoradorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entidades.Models.Morador", b =>
                {
                    b.HasOne("Entidades.Models.Apartamento", "Apartamento")
                        .WithMany("Moradores")
                        .HasForeignKey("ApartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entidades.Models.Condominio", "Condominio")
                        .WithMany("Moradores")
                        .HasForeignKey("CondominioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entidades.Models.Sindico", "Sindico")
                        .WithOne("Morador")
                        .HasForeignKey("Entidades.Models.Morador", "SindicoId");
                });

            modelBuilder.Entity("Entidades.Models.ServicoCondominio", b =>
                {
                    b.HasOne("Entidades.Models.Condominio", "Condominio")
                        .WithMany("ServicoCodominios")
                        .HasForeignKey("CondominioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entidades.Models.Servico", "Servico")
                        .WithMany("ServicoCodominios")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entidades.Models.Sindico", b =>
                {
                    b.HasOne("Entidades.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}