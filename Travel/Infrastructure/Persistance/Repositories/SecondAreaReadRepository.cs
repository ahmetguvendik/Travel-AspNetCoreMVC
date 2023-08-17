using System;
using Application.Repositories;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
	public class SecondAreaReadRepository : ReadRepository<SecondArea>, ISecondAreaReadRepository
    {
        public SecondAreaReadRepository(ProjectDbContext context) : base(context)
        {
        }
    }
}

