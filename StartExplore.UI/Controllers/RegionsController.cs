using Microsoft.AspNetCore.Mvc;
using StartExplore.UI.Models.DTO;
using System.Threading.Tasks;

namespace StartExplore.UI.Controllers
{
    public class RegionsController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public RegionsController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            List<RegionDto> response = new List<RegionDto>();
            try
            {
                // Get all Region from Web API
                var client = httpClientFactory.CreateClient();

                var httpResponseMessage = await client.GetAsync("https://localhost:7223/api/regions");

                httpResponseMessage.EnsureSuccessStatusCode();
                
                response.AddRange(await httpResponseMessage.Content.ReadFromJsonAsync<IEnumerable<RegionDto>>());
                
            }
            catch (Exception ex)
            {
                // Log the exception
                
            }

            return View(response);
        }
    }
} 
