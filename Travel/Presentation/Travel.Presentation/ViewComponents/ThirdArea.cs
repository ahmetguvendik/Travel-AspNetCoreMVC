using System;
using Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Presentation.ViewComponents
{
	public class ThirdArea : ViewComponent
	{
        private readonly IThirdAreaReadRepository _thirdAreaReadRepository;
		public ThirdArea(IThirdAreaReadRepository thirdAreaReadRepository)
		{
            _thirdAreaReadRepository = thirdAreaReadRepository;
		}

        public IViewComponentResult Invoke()
        {
            var values = _thirdAreaReadRepository.GetAll();
            return View(values);
        }
    }
}

