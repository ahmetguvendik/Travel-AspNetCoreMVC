using System;
using Application.Repositories;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
	public class FirstAreaReadRepository : ReadRepository<FirstArea>, IFirstAreaReadRepository
    {
		public FirstAreaReadRepository(ProjectDbContext context) : base(context)
        {
		}
	}
}

