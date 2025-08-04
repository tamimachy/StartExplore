using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StartExplore.API.Models.DTO;

namespace StartExplore.API.Controllers
{
    // /api/walks
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        public WalksController(IMapper mapper)
        {
            this.mapper = mapper;
        }
        // CREATE Walks
        // POST: /api/walks
        public async Task<IActionResult> Create([FromBody] AddWalksRequestDto addWalksRequestDto)
        {
            // Mapp DTO to Domain Model
        }
    }
}
