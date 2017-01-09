namespace Imperugo.Syncfusion.Video.AspNetCore.Demo._006
{
	public class MyConfiguration
	{
		public Database Database { get; set; }
		public Facebook Facebook { get; set; }
		public Smtp Smtp { get; set; }
	}

	public class Database
	{
		public string DatabaseName { get; set; }
		public string ServerHost { get; set; }
		public int Port { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}

	public class Facebook
	{
		public string AppId { get; set; }
		public string AppSecret { get; set; }
	}

	public class Smtp
	{
		public string Host { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public bool EnableSsl { get; set; }
		public int Port { get; set; }
	}
}
