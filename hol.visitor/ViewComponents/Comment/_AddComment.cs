using System;
using Microsoft.AspNetCore.Mvc;

namespace hol.visitor.ViewComponents.Comment
{
	public class _AddComment : ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

