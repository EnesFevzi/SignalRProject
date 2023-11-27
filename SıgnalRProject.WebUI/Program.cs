using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using NToastNotify;
using SıgnalRProject.DataAccess.Context;
using SıgnalRProject.DataAccess.Extensions;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.WebUI.FluentValidations;
using System.Globalization;

namespace SıgnalRProject.WebUI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddHttpClient();
			builder.Services.AddAuthorization();
			builder.Services.LoadDataLayerExtension(builder.Configuration);
			builder.Services.AddSession();
			builder.Services.AddControllersWithViews()
				.AddFluentValidation(opt =>
				{
					opt.RegisterValidatorsFromAssemblyContaining<UserValidator>();
					opt.DisableDataAnnotationsValidation = true;
					opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
				}).AddNToastNotifyToastr(new ToastrOptions()
				{
					PositionClass = ToastPositions.TopRight,
					TimeOut = 3000,
				})
			 .AddRazorRuntimeCompilation();

			builder.Services.AddIdentity<AppUser, AppRole>(opt =>
			{
				opt.Password.RequireNonAlphanumeric = false;
				opt.Password.RequireLowercase = false;
				opt.Password.RequireUppercase = false;
				opt.User.RequireUniqueEmail = true;

			})
			 .AddRoleManager<RoleManager<AppRole>>()
			 .AddErrorDescriber<IdentityErrorDescriber>()
			 .AddEntityFrameworkStores<SıgnalRContext>()
			.AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider);

			builder.Services.ConfigureApplicationCookie(config =>
			{
				config.LoginPath = new PathString("/Auth/Login");
				config.LogoutPath = new PathString("/Auth/Logout");
				config.Cookie = new CookieBuilder
				{
					Name = "MySignalRProjectCookie",
					HttpOnly = true,
					SameSite = SameSiteMode.Strict,
					SecurePolicy = CookieSecurePolicy.SameAsRequest //Always 

				};
				config.SlidingExpiration = true;
				config.ExpireTimeSpan = TimeSpan.FromDays(7);
				config.AccessDeniedPath = new PathString("/Auth/AccessDenied");

			});


			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseStatusCodePagesWithReExecute("/Auth/Error404/");
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseSession();
			app.UseAuthentication();
			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}