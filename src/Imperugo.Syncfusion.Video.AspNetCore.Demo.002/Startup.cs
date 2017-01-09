using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Imperugo.Syncfusion.Video.AspNetCore.Demo._002
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

			/*
			 * Enable static files
			 */
			app.UseStaticFiles();

			/*
			 * Enable static files with default document ("default.htm", "default.html", "index.htm" and "index.html")
			 */
			//app.UseFileServer();


			/*
			 * If you want to override the default document names
			 */

			/*
			var options = new DefaultFilesOptions();
			options.DefaultFileNames.Clear();
			options.DefaultFileNames.Add("custom-index.html");
			app.UseDefaultFiles(options);
			app.UseFileServer();
			*/

			app.Run(async (context) =>
			{
				await context.Response.WriteAsync("Hello World!");
			});
		}
	}
}
