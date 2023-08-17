using System;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Presentation.ViewComponents
{
	public class SecondArea : ViewComponent
	{
        private readonly ISecondAreaReadRepository _secondAreaReadRepository;
        public SecondArea(ISecondAreaReadRepository secondAreaReadRepository)
		{
            _secondAreaReadRepository = secondAreaReadRepository;
		}

        public IViewComponentResult Invoke()
        {
            var values = _secondAreaReadRepository.GetAll();
            return View(values);
        }
    }
}

