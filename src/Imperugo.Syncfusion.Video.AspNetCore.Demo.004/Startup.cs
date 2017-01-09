using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Imperugo.Syncfusion.Video.AspNetCore.Demo._004
{
	/*
	 *	This class is the entry point of the ASP.NET application
	 *	Everything about configuration, pipeline, logging and more and initialized in this class
	 */
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			//Here we have to register the services we want to use with the Dependency Injection
			//More info here https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection

			services.AddMvc();
		}

		public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole();

			// In case you want to see the exception information into the web page
			// Never use this on production
			//app.UseDeveloperExceptionPage();

			// In case you want to show a friendly error page (to use on production)
			app.UseExceptionHandler("/Home/Error");
			app.UseStatusCodePagesWithRedirects("/Home/Error/{0}");

			app.UseStaticFiles();
			app.UseMvcWithDefaultRoute();
		}
	}
}
