using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Imperugo.Syncfusion.Video.AspNetCore.Demo._003
{
	/*
	 *	This class is the entry point of the ASP.NET application
	 *	Everything about configuration, pipeline, logging and more and initialized in this class
	 */
	public class Startup
	{
		private readonly ILoggerFactory loggerFactory;
		private readonly ILogger<Startup> logger;

		public Startup(ILoggerFactory loggerFactory)
		{
			this.loggerFactory = loggerFactory;
			this.logger = loggerFactory.CreateLogger<Startup>();
		}

		public void ConfigureServices(IServiceCollection services)
		{
			//Here we have to register the services we want to use with the Dependency Injection
			//More info here https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection

			services.AddSingleton<FakeUserService>();
		}

		public void Configure(IApplicationBuilder app, FakeUserService userService)
		{
			//This add log information into the console stream (need to run using Kestrel and not IIS)
			loggerFactory.AddConsole();

			// Because the minimum log level is Information, if uou log debug info you can't see them into the output
			// in this case you must change the minimum log level to debug
			//loggerFactory.AddConsole(LogLevel.Debug);

			//This add log information into Visual Studio debug stream (View => Output or CTRL+ALT+O)
			loggerFactory.AddDebug();

			app.Run(async (context) =>
			{
				this.logger.LogInformation("Logging custom information......");
				userService.DoSomething();
				await context.Response.WriteAsync("Hello World!");
			});
		}
	}
}
