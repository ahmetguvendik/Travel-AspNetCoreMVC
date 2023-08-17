using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Contexts
{
	public class ProjectDbContext : DbContext
    {
		public ProjectDbContext(DbContextOptions options) : base(options) { }

		public DbSet<FirstArea> FirstAreas { get; set; }
		public DbSet<SecondArea> SecondAreas { get; set; }
        public DbSet<ThirdArea> ThirdAreas { get; set; }
        public DbSet<ForthArea> ForthAreas { get; set; }
        public DbSet<FifthArea> FifthAreas { get; set; }
        public DbSet<NewsArea> NewsAreas { get; set; }
    }
}


