using System;
using Application.Repositories;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
	public class FiftAreaReadRepository : ReadRepository<FifthArea>, IFiftAreaReadRepository
    {
        public FiftAreaReadRepository(ProjectDbContext context) : base(context)
        {
        }
    }
}

