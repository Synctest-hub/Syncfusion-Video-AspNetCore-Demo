using Microsoft.AspNetCore.Hosting;

namespace Imperugo.Syncfusion.Video.AspNetCore.Demo._005.Extensions
{
	public static class HostingEnvironmentExtensions
	{
		public static bool IsQualityAssurance(this IHostingEnvironment env)
		{
			return env.EnvironmentName == "QualityAssurance";
		}
	}
}