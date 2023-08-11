using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Contexts
{
	public class ProjectDbContext : DbContext
    {
		public ProjectDbContext(DbContextOptions options) : base(options) { }

		public DbSet<FirstArea> FirstAreas { get; set; }	
	}
}


