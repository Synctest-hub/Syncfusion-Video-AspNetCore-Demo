using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Imperugo.Syncfusion.Video.AspNetCore.Demo._006
{
	/*
	 *	This class is the entry point of the .NET (console) application
	 *	and here we are going to create our web host
	 */
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = new WebHostBuilder()
				.UseKestrel()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseIISIntegration()
				.UseStartup<Startup>()
				.Build();

			host.Run();
		}
	}
}
