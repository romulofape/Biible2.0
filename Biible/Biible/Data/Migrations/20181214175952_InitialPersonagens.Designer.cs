﻿// <auto-generated />
using System;
using Biible.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Biible.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181214175952_InitialPersonagens")]
    partial class InitialPersonagens
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Biible.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Biible.Models.Curiosidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Curtida");

                    b.Property<DateTime>("Data_Cadastro");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int?>("PersonagemId");

                    b.HasKey("Id");

                    b.HasIndex("PersonagemId");

                    b.ToTable("Curiosidades");
                });

            modelBuilder.Entity("Biible.Models.Genealogia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data_Cadastro");

                    b.Property<int>("IdPersonagem1");

                    b.Property<int>("IdPersonagem2");

                    b.Property<int?>("PersonagemId");

                    b.HasKey("Id");

                    b.HasIndex("PersonagemId");

                    b.ToTable("Genealogias");
                });

            modelBuilder.Entity("Biible.Models.Outro_Nome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ano");

                    b.Property<DateTime>("Data_Cadastro");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int?>("PersonagemId");

                    b.HasKey("Id");

                    b.HasIndex("PersonagemId");

                    b.ToTable("Outros_Nomes");
                });

            modelBuilder.Entity("Biible.Models.PassagemBiblica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capitulo");

                    b.Property<int?>("CuriosidadeId");

                    b.Property<int?>("GenealogiaId");

                    b.Property<int>("Livro");

                    b.Property<int?>("Outro_NomeId");

                    b.Property<int?>("RegiaoId");

                    b.Property<int>("Versiculo");

                    b.HasKey("Id");

                    b.HasIndex("CuriosidadeId");

                    b.HasIndex("GenealogiaId");

                    b.HasIndex("Outro_NomeId");

                    b.HasIndex("RegiaoId");

                    b.ToTable("Passages_Biblicas");
                });

            modelBuilder.Entity("Biible.Models.Personagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ano_Fim");

                    b.Property<bool>("Ano_Fim_AcDc");

                    b.Property<bool>("Ano_Fim_Incerto");

                    b.Property<int>("Ano_Inicio");

                    b.Property<bool>("Ano_Inicio_AcDc");

                    b.Property<bool>("Ano_Inicio_Incerto");

                    b.Property<int>("Curtida");

                    b.Property<DateTime>("Data_Cadastro");

                    b.Property<string>("Etnia");

                    b.Property<byte>("Foto");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Referencia");

                    b.Property<string>("Usuario_Cadastro");

                    b.HasKey("Id");

                    b.ToTable("Personagens");
                });

            modelBuilder.Entity("Biible.Models.Referencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data_Cadastro");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int?>("PersonagemId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("PersonagemId");

                    b.ToTable("Referencias");
                });

            modelBuilder.Entity("Biible.Models.Regiao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data_Cadastro");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int?>("PersonagemId");

                    b.HasKey("Id");

                    b.HasIndex("PersonagemId");

                    b.ToTable("Regioes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Biible.Models.Curiosidade", b =>
                {
                    b.HasOne("Biible.Models.Personagem")
                        .WithMany("Curiosidades")
                        .HasForeignKey("PersonagemId");
                });

            modelBuilder.Entity("Biible.Models.Genealogia", b =>
                {
                    b.HasOne("Biible.Models.Personagem")
                        .WithMany("Genealogias")
                        .HasForeignKey("PersonagemId");
                });

            modelBuilder.Entity("Biible.Models.Outro_Nome", b =>
                {
                    b.HasOne("Biible.Models.Personagem")
                        .WithMany("Outros_Nomes")
                        .HasForeignKey("PersonagemId");
                });

            modelBuilder.Entity("Biible.Models.PassagemBiblica", b =>
                {
                    b.HasOne("Biible.Models.Curiosidade")
                        .WithMany("Passagens_Biblicas")
                        .HasForeignKey("CuriosidadeId");

                    b.HasOne("Biible.Models.Genealogia")
                        .WithMany("Passagens_Biblicas")
                        .HasForeignKey("GenealogiaId");

                    b.HasOne("Biible.Models.Outro_Nome")
                        .WithMany("Passagens_Biblicas")
                        .HasForeignKey("Outro_NomeId");

                    b.HasOne("Biible.Models.Regiao")
                        .WithMany("Passagens_Biblicas")
                        .HasForeignKey("RegiaoId");
                });

            modelBuilder.Entity("Biible.Models.Referencia", b =>
                {
                    b.HasOne("Biible.Models.Personagem")
                        .WithMany("Referencias")
                        .HasForeignKey("PersonagemId");
                });

            modelBuilder.Entity("Biible.Models.Regiao", b =>
                {
                    b.HasOne("Biible.Models.Personagem")
                        .WithMany("Regioes")
                        .HasForeignKey("PersonagemId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Biible.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Biible.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Biible.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Biible.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}