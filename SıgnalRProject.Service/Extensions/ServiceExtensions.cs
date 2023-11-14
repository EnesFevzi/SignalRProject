using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SıgnalRProject.DataAccess.Repositories.Abstract;
using SıgnalRProject.DataAccess.Repositories.Concrete;
using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Service.FluentValidations;
using SıgnalRProject.Service.Services.Abstract;
using SıgnalRProject.Service.Services.Concrete;
using System.Globalization;
using System.Reflection;

namespace SıgnalRProject.Service.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
           
            services.AddAutoMapper(assembly);
           
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); 
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IDiscountService, DiscountService>();
            services.AddScoped<IFeatureService, FeatureService>();
            services.AddScoped<IMenuTableService, MenuTableService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IMoneyCaseService, MoneyCaseService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService,ProductService>();
            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<ISocialMediaService, SocialMediaService>();
            services.AddScoped<ITestimonialService, TestimonialService>();

            services.AddControllersWithViews()
                .AddFluentValidation(opt =>
                {
                    opt.RegisterValidatorsFromAssemblyContaining<CategoryValidator>();
                    opt.DisableDataAnnotationsValidation = true;
                    opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
                });

            return services;


        }
    }
}
