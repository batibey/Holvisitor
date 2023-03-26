using System;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace hol.visitor.ViewComponents.Default
{
	public class _Feature : ViewComponent
	{
        FeatureManager featureManager = new FeatureManager(new EfFeatureDAL());

        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}

