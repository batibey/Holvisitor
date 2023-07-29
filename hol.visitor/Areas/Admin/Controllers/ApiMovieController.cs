using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using hol.visitor.Areas.Admin.Models;
using Newtonsoft.Json;

namespace hol.visitor.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiMovieController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ApiMovieViewModel> apiMovies = new List<ApiMovieViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies1.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "9c12b0dd65mshe7c68d5111f5868p145776jsn966eb301c2d4" },
        { "X-RapidAPI-Host", "imdb-top-100-movies1.p.rapidapi.com" },
    },
            };
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            apiMovies = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
            return View(apiMovies);
        }
    }
}
