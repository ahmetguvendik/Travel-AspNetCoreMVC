using System;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Presentation.ViewComponents
{
	public class NewsArea : ViewComponent
	{
        private readonly INewsAreaReadRepository _newsAreaReadRepository;
		public NewsArea(INewsAreaReadRepository newsAreaReadRepository)
		{
            _newsAreaReadRepository = newsAreaReadRepository;
		}

        public IViewComponentResult Invoke()
        {
            var values = _newsAreaReadRepository.GetAllList();
            return View(values);
        }
    }
}

