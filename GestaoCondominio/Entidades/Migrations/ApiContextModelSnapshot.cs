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
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
<<<<<<< HEAD
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");
=======
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d

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

<<<<<<< HEAD
                    b.Property<int?>("SindicoId");
=======
                    b.Property<int?>("SindicosId");
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("EstadoId");

<<<<<<< HEAD
                    b.HasIndex("SindicoId")
=======
                    b.HasIndex("SindicosId")
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d
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
<<<<<<< HEAD
                    b.HasOne("Entidades.Models.Apartamento", "Apartamento")
=======
                    b.HasOne("Entidades.Models.Apartamento", "Apartamentos")
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d
                        .WithMany("ApartamentoCondominios")
                        .HasForeignKey("ApartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

<<<<<<< HEAD
                    b.HasOne("Entidades.Models.Condominio", "Condominio")
=======
                    b.HasOne("Entidades.Models.Condominio", "Condominios")
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d
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
<<<<<<< HEAD
                    b.HasOne("Entidades.Models.Cidade", "Cidade")
=======
                    b.HasOne("Entidades.Models.Cidade", "Cidades")
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d
                        .WithMany("Condominios")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

<<<<<<< HEAD
                    b.HasOne("Entidades.Models.Estado", "Estado")
=======
                    b.HasOne("Entidades.Models.Estado", "Estados")
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d
                        .WithMany("Condominios")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);

<<<<<<< HEAD
                    b.HasOne("Entidades.Models.Sindico", "Sindico")
                        .WithOne("Condominio")
                        .HasForeignKey("Entidades.Models.Condominio", "SindicoId");
=======
                    b.HasOne("Entidades.Models.Sindico", "Sindicos")
                        .WithOne("Condominios")
                        .HasForeignKey("Entidades.Models.Condominio", "SindicosId");
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d
                });

            modelBuilder.Entity("Entidades.Models.ContaMorador", b =>
                {
<<<<<<< HEAD
                    b.HasOne("Entidades.Models.Morador", "Morador")
=======
                    b.HasOne("Entidades.Models.Morador", "Moradores")
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d
                        .WithMany("ContaMoradores")
                        .HasForeignKey("MoradorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entidades.Models.Morador", b =>
                {
<<<<<<< HEAD
                    b.HasOne("Entidades.Models.Apartamento", "Apartamento")
=======
                    b.HasOne("Entidades.Models.Apartamento", "Apartamentos")
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d
                        .WithMany("Moradores")
                        .HasForeignKey("ApartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

<<<<<<< HEAD
                    b.HasOne("Entidades.Models.Condominio", "Condominio")
=======
                    b.HasOne("Entidades.Models.Condominio", "Condominios")
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d
                        .WithMany("Moradores")
                        .HasForeignKey("CondominioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Entidades.Models.Sindico", "Sindico")
<<<<<<< HEAD
                        .WithOne("Morador")
=======
                        .WithOne("Moradores")
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d
                        .HasForeignKey("Entidades.Models.Morador", "SindicoId");
                });

            modelBuilder.Entity("Entidades.Models.ServicoCondominio", b =>
                {
<<<<<<< HEAD
                    b.HasOne("Entidades.Models.Condominio", "Condominio")
=======
                    b.HasOne("Entidades.Models.Condominio", "Condominios")
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d
                        .WithMany("ServicoCodominios")
                        .HasForeignKey("CondominioId")
                        .OnDelete(DeleteBehavior.Cascade);

<<<<<<< HEAD
                    b.HasOne("Entidades.Models.Servico", "Servico")
=======
                    b.HasOne("Entidades.Models.Servico", "Servicos")
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d
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
