﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videotheque.Model;
using static System.Environment;

namespace Videotheque.DataAccess
{
    class DbService : DbContext
    {
        //Attributs
        private static DbService INSTANCE = null;
        public string DatabasePath { get; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GenreMedia> GenreMedias { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<PersonneMedia> PersonneMedias { get; set; }


        internal DbService(DbContextOptions options) : base(options) { }
        private DbService(string dbPath) : base()
        {
            this.DatabasePath = dbPath;
        }
        public static async Task<DbService> getInstance()
        {
            if (INSTANCE == null)
            {
                //INSTANCE= new DbService(Path.Combine(GetFolderPath(SpecialFolder.LocalApplicationData), "database.db"));
                // Move database in project directory
                INSTANCE = new DbService(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "\\database\\database.db" );
                await INSTANCE.Database.MigrateAsync();
            }
            return INSTANCE;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GenreMedia>()
                                .HasKey(ab => new { ab.IdGenre, ab.IdMedia });
        }
    }
}
