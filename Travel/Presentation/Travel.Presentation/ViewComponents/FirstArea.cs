using System;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Presentation.ViewComponents
{
	public class FirstArea : ViewComponent
	{
        private readonly IFirstAreaReadRepository _firstAreaReadRepository;

        public FirstArea(IFirstAreaReadRepository firstAreaReadRepository)
        {
            _firstAreaReadRepository = firstAreaReadRepository;
        }

        public IViewComponentResult Invoke()
		{
            var values = _firstAreaReadRepository.GetAll();
            return View(values);
        }
	}
}

