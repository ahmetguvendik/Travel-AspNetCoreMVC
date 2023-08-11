﻿using System;
using Domain.Entities;

namespace Application.Repositories
{
	public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        T GetAll();
        Task<T> GetById(string id);
    }
}

