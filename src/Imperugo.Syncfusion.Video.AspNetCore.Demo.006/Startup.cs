using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Imperugo.Syncfusion.Video.AspNetCore.Demo._005.Extensions;
using Microsoft.Extensions.Configuration;

namespace Imperugo.Syncfusion.Video.AspNetCore.Demo._006
{
	/*
	 *	This class is the entry point of the ASP.NET application
	 *	Everything about configuration, pipeline, logging and more and initialized in this class
	 */
	public class Startup
	{
		private readonly IHostingEnvironment env;
		private readonly MyConfiguration configuration;

		public Startup(IHostingEnvironment env)
		{
			this.env = env;
			this.configuration = new MyConfiguration();

			new ConfigurationBuilder()
				.SetBasePath(this.env.ContentRootPath)
				.AddJsonFile("appsettings.json", false, true)
				.AddJsonFile($"appsettings.{this.env.EnvironmentName}.json", true)
				.AddEnvironmentVariables()
				.Build()
				.Bind(configuration);
		}

		public void ConfigureServices(IServiceCollection services)
		{
			//Here we have to register the services we want to use with the Dependency Injection
			//More info here https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection

			services.AddMvc();
			services.AddSingleton(configuration);
		}

		public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole();

			if (env.IsDevelopment())
			{
				// In case you want to see the exception information into the web page
				// Never use this on production
				//app.UseDeveloperExceptionPage();
			}
			if (env.IsStaging())
			{
				//Do whatever you want for your staging environment
			}
			else if (env.IsQualityAssurance()) // is the same of "this.env.EnvironmentName == "QualityAssurance"
			{
				//Do whatever you want for your quality assurance environment
			}
			else
			{
				// In case you want to show a friendly error page (to use on production)
				app.UseExceptionHandler("/Home/Error");
				app.UseStatusCodePagesWithRedirects("/Home/Error/{0}");
			}

			app.UseStaticFiles();
			app.UseMvcWithDefaultRoute();
		}
	}
}
