using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace hol.visitor.ViewComponents.Comment
{
	public class _CommentList : ViewComponent
	{

		CommentManager commentManager = new CommentManager(new EfCommentDAL());
		public IViewComponentResult Invoke(int id)
		{
			var values = commentManager.TGetDestinationByID(id);
			return View(values);
		}
	}
}

