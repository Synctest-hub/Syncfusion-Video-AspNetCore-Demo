using Microsoft.Extensions.Logging;

namespace Imperugo.Syncfusion.Video.AspNetCore.Demo._003
{
	public class FakeUserService
	{
		private readonly ILogger<FakeUserService> logger;

		public FakeUserService(ILogger<FakeUserService> logger)
		{
			this.logger = logger;
		}

		public void DoSomething()
		{
			this.logger.LogInformation("Ok, I'm doing something.");
		}
	}
}