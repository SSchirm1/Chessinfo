using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chessinfo.Models;

namespace Chessinfo.Data
{
    public class ChessinfoContext : DbContext
    {
        public ChessinfoContext (DbContextOptions<ChessinfoContext> options)
            : base(options)
        {
        }

        public DbSet<Chessinfo.Models.Player> Player { get; set; } = default!;
        public DbSet<Chessinfo.Models.Game> Game { get; set; } = default!;
        public DbSet<Chessinfo.Models.Title> Title { get; set; } = default!;
        public DbSet<Chessinfo.Models.Country> Country { get; set; } = default!;
        public DbSet<Chessinfo.Models.Tournament> Tournament { get; set; } = default!;
    }
}
