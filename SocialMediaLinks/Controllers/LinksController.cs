using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models.Options;

namespace SocialMediaLinks.Controllers
{
	public class LinksController : Controller
	{
		private readonly SocialMediaLinksOptions _options;

        public LinksController(
			IOptions<SocialMediaLinksOptions> options
			)
        {
			_options = options.Value;
        }

        [Route("/")]
		[HttpGet]
		public IActionResult Index()
		{
			return View(_options);
		}
	}
}
