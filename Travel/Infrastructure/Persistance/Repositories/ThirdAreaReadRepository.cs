using System;
using Application.Repositories;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
	public class ThirdAreaReadRepository : ReadRepository<ThirdArea>, IThirdAreaReadRepository
    {
        public ThirdAreaReadRepository(ProjectDbContext context) : base(context)
        {
        }
    }
}

