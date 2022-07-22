using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationCancellationToken.Models;

namespace WebApplicationCancellationToken.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            await DownloadAsync("https://www.bing.com", 100, cancellationToken);
            return View();
        }
        /// <summary>
        /// 下载N次网站，传递CancellationToken中断请求
        /// </summary>
        async Task DownloadAsync(string url, int n, CancellationToken cancellationToken)
        {
            using HttpClient httpClient = new HttpClient();
            for (int i = 0; i < n; i++)
            {
                var response = await httpClient.GetAsync(url, cancellationToken);
                string content = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(content.Substring(0, 15));
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}