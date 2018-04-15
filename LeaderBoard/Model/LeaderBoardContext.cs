using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderBoard.Model
{
    public class LeaderBoardContext : DbContext
    {
        public DbSet<LeaderBoardEntry> Entries { get; set; }

        public LeaderBoardContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=leadboard.db");
        }

        public IEnumerable<LeaderBoardEntry> Leaders()
        {
            return Entries.OrderByDescending(x => x.Score);
        }
        public IEnumerable<LeaderBoardEntry> Leaders(int count)
        {
            return Entries.OrderByDescending(x => x.Score).Take(count);
        }
    }

    
}
