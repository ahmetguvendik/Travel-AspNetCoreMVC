using System;
using Application.Repositories;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
	public class ForthAreaReadRepository : ReadRepository<ForthArea>, IForthAreaReadRepository
    {
        public ForthAreaReadRepository(ProjectDbContext context) : base(context)
        {
        }
    }
}

