using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
	public class EfTestimonialDAL : GenericRepository<Testimonial>, ITestimonialDAL
    {
		
	}
}

