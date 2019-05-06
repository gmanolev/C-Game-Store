using GameStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace GameStore.Data
{
    public class GameStoreDb:DbContext
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GEORGE-PC;Database=GameStoreDb;Integrated Security=true");
        }
    }
}
