﻿using System;
using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;

namespace Persistance.Repositories
{
	public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ProjectDbContext _context;
		public ReadRepository(ProjectDbContext context)
		{
            _context = context;
		}

        public DbSet<T> Table => _context.Set<T>();

        public T GetAll()
        {
            return Table.FirstOrDefault();
        }

        public IQueryable<T> GetAllList()
        {
            return Table;
        }

        public async Task<T> GetById(string id)
        {
            return await Table.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}

