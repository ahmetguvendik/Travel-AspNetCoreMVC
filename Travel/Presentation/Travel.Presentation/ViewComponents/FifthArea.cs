using System;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Presentation.ViewComponents
{
	public class FifthArea : ViewComponent
	{
		public FifthArea()
		{
		}

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

