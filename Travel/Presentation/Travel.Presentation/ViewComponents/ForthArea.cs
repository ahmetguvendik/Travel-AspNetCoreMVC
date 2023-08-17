using System;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Presentation.ViewComponents
{
	public class ForthArea : ViewComponent
	{
		public ForthArea()
		{
		}

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

