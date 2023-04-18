using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesController : ControllerBase
    {
        private ApiDbContext _apiDbContext;
        public TimesController(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        [HttpGet]
        public IActionResult GetSaatlerByTarihVeSehir(int cityId, int dateId)
        {
            var saatler = _apiDbContext.Times
                .Where(c => c.cities.Id == cityId && c.Dates.Id == dateId)
                .ToList();
            return Ok(saatler);
        }
    }
}
