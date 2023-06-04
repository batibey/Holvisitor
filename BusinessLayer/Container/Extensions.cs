using System;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Container
{
	public static class Extensions
	{
		public static void ContainerDependencies(this IServiceCollection services)
		{
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDAL, EfCommentDAL>();

            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDAL, EfDestinationDAL>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDAL, EfAppUserDAL>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDAL, EfReservationDAL>();

            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDAL, EfGuideDAL>();
        }
	}
}

