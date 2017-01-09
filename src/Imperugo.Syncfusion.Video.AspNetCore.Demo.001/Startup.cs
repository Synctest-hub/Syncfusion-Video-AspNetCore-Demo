using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Imperugo.Syncfusion.Video.AspNetCore.Demo._001
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
		}

		public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole();

			app.Run(async (context) =>
			{
				await context.Response.WriteAsync("Hello World!");
			});
		}
	}
}
