using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace hol.visitor.ViewComponents.Default
{
	public class _Testimonial : ViewComponent
	{
		TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDAL());

		public IViewComponentResult Invoke()
		{
			var values = testimonialManager.TGetList();
			return View(values);
		}
	}
}

