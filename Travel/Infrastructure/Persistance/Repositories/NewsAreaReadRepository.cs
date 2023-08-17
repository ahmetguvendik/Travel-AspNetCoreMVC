using System;
using Application.Repositories;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
	public class NewsAreaReadRepository : ReadRepository<NewsArea>, INewsAreaReadRepository
    {
        public NewsAreaReadRepository(ProjectDbContext context) : base(context)
        {
        }
    }
}

