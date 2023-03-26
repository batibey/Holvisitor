using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace hol.visitor.ViewComponents.Default
{
	public class _SubAbout : ViewComponent
	{
		SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDAL());
		
		public IViewComponentResult Invoke()
		{
			var values = subAboutManager.TGetList();
			return View(values);
		}
	}
}

