using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
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

            services.AddScoped<IExcelService, ExcelManager>();

            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDAL, EfContactUsDAL>();

        }

        public static void CustomerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();
        }
	}
}

