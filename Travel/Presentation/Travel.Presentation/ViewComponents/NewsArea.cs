using System;
using Microsoft.AspNetCore.Mvc;

namespace Travel.Presentation.ViewComponents
{
	public class NewsArea : ViewComponent
	{
		public NewsArea()
		{
		}

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

