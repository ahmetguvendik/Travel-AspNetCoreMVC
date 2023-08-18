using System;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Presentation.ViewComponents
{
	public class FifthArea : ViewComponent
	{
        private readonly IFiftAreaReadRepository _fiftAreaReadRepository;
		public FifthArea(IFiftAreaReadRepository fiftAreaReadRepository)
		{
            _fiftAreaReadRepository = fiftAreaReadRepository;
		}

        public IViewComponentResult Invoke()
        {
            var values = _fiftAreaReadRepository.GetAll();
            return View(values);
        }
    }
}

