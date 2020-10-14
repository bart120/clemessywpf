using clemessywpf.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clemessywpf.Data
{
    public class ClemessyDbContext : DbContext
    {
        public ClemessyDbContext() : base("ClemessyConnection")
        {

        }

        public DbSet<Piece> Pieces { get; set; }
    }
}
