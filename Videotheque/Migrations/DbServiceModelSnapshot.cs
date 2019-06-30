﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Videotheque.DataAccess;

namespace Videotheque.Migrations
{
    [DbContext(typeof(DbService))]
    partial class DbServiceModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Videotheque.Model.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateDiffusion");

                    b.Property<string>("Description");

                    b.Property<TimeSpan>("Duree");

                    b.Property<int>("IdMedia");

                    b.Property<int>("NumEpisode");

                    b.Property<int>("NumSaison");

                    b.Property<string>("Titre");

                    b.HasKey("Id");

                    b.HasIndex("IdMedia");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("Videotheque.Model.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Libelle");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Videotheque.Model.GenreMedia", b =>
                {
                    b.Property<int>("IdGenre");

                    b.Property<int>("IdMedia");

                    b.HasKey("IdGenre", "IdMedia");

                    b.HasIndex("IdMedia");

                    b.ToTable("GenreMedias");
                });

            modelBuilder.Entity("Videotheque.Model.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AgeMin");

                    b.Property<string>("Commentaire");

                    b.Property<DateTime>("DateSortie");

                    b.Property<TimeSpan>("Duree");

                    b.Property<string>("Image");

                    b.Property<int>("LangueMedia");

                    b.Property<int>("LangueVO");

                    b.Property<int>("Note");

                    b.Property<int>("SousTitres");

                    b.Property<bool>("SupportNumerique");

                    b.Property<bool>("SupportPhysique");

                    b.Property<string>("Synopsis");

                    b.Property<string>("Titre");

                    b.Property<int>("TypeMedia");

                    b.Property<bool>("Vu");

                    b.HasKey("Id");

                    b.ToTable("Medias");
                });

            modelBuilder.Entity("Videotheque.Model.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Civilite");

                    b.Property<DateTime>("DateNaissance");

                    b.Property<string>("Nationalite");

                    b.Property<string>("Nom");

                    b.Property<string>("Photo");

                    b.Property<string>("Prenom");

                    b.HasKey("Id");

                    b.ToTable("Personnes");
                });

            modelBuilder.Entity("Videotheque.Model.PersonneMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Fonction");

                    b.Property<int>("IdMedia");

                    b.Property<int>("IdPersonne");

                    b.Property<string>("Role");

                    b.HasKey("Id");

                    b.HasIndex("IdMedia");

                    b.HasIndex("IdPersonne");

                    b.ToTable("PersonneMedias");
                });

            modelBuilder.Entity("Videotheque.Model.Episode", b =>
                {
                    b.HasOne("Videotheque.Model.Media", "Media")
                        .WithMany("LesEpisodes")
                        .HasForeignKey("IdMedia")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Videotheque.Model.GenreMedia", b =>
                {
                    b.HasOne("Videotheque.Model.Genre", "Genre")
                        .WithMany("LesMedias")
                        .HasForeignKey("IdGenre")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Videotheque.Model.Media", "Media")
                        .WithMany("LesGenres")
                        .HasForeignKey("IdMedia")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Videotheque.Model.PersonneMedia", b =>
                {
                    b.HasOne("Videotheque.Model.Media", "Media")
                        .WithMany("LesPersonnes")
                        .HasForeignKey("IdMedia")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Videotheque.Model.Personne", "Personne")
                        .WithMany("LesMedias")
                        .HasForeignKey("IdPersonne")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
