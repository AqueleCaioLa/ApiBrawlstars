using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiBrawlstars.Models;

namespace ApiBrawlstars.Data
{
    public class DbBsContext : DbContext
    {
        public DbBsContext (DbContextOptions<DbBsContext> options)
            : base(options)
        {
        }

        public DbSet<ApiBrawlstars.Models.Brawlstar> Brawlstar { get; set; } = default!;

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brawlstar>().HasData(
                new Brawlstar {
                    Id = 1,
                    Nome = "Shelly",
                    Tipo = "Destruidor",
                    Ano = 2018,
                    Foto = "https://liquipedia.net/commons/images/f/f6/Brawl_Shelly.png",
                    Regiao = "Velho Oeste",
                    Raridade = "Inicial",
                    Lane = "Lateral",
                    Status = "Ativo" },

                new Brawlstar {
                    Id = 2, Nome = "Nita",
                    Tipo = "Destruidor",
                    Ano = 2018,
                    Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXTwLLQ1N2m6Li9bMtYmChaymQx1qZUtu2-A&s",
                    Regiao = "Tribo Shaman",
                    Raridade = "Raro",
                    Lane = "Lateral",
                    Status = "Ativo"
                }
                ); 
        }
    }
}
