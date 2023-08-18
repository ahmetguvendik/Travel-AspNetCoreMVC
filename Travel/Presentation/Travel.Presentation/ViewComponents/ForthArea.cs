using System;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Presentation.ViewComponents
{
	public class ForthArea : ViewComponent
	{
        private readonly IForthAreaReadRepository _forthAreaReadRepository;
		public ForthArea(IForthAreaReadRepository forthAreaReadRepository)
		{
            _forthAreaReadRepository = forthAreaReadRepository;
		}

        public IViewComponentResult Invoke()
        {
            var values = _forthAreaReadRepository.GetAllList();
            return View(values);
        }
    }
}

