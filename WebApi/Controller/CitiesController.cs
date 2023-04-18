using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;
using WebApi.Data;

namespace WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private ApiDbContext _apiDbContext;
        public CitiesController(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetCities()
        {
            var cities = await (from city in _apiDbContext.Cities
                                select new
                                {
                                    Id = city.Id,
                                    CityName = city.CityName,
                                }
                ).ToListAsync();
            return Ok(cities);
        }

    }
}
