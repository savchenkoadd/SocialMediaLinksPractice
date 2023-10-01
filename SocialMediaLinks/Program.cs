namespace SocialMediaLinks
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews();
			builder.Services.Configure<Models.Options.SocialMediaLinksOptions>(
				builder.Configuration.GetSection("SocialMediaLinks"));

			var app = builder.Build();

			app.UseStaticFiles();
			app.UseRouting();
			app.MapControllers();

			app.Run();
		}
	}
}