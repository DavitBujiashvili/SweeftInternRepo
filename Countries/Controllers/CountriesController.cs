using AutoMapper;
using Countries.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Countries.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly ICountriesApi _countriesApi;
        private readonly IWebHostEnvironment _environment;
        private readonly IMapper _mapper;

        public CountriesController(
            ICountriesApi countriesApi,
            IWebHostEnvironment environment,
            IMapper mapper)
        {
            _countriesApi = countriesApi;
            _environment = environment;
            _mapper = mapper;
        }

        [HttpGet(Name = "GenerateCountryDataFiles")]
        public async Task<IActionResult> Get(CancellationToken token)
        {
            var rootFolder = _environment.WebRootPath;
            var newPath = Path.Combine(rootFolder, "Counties");
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }

            var countireList = await _countriesApi.GetAllCountries();

            foreach (var country in countireList)
            {
                var fileName = Path.Combine(newPath, $"{country.Name.Common}.txt");
                string dataString = JsonSerializer.Serialize(_mapper.Map<CountryInfo>(country));

                await System.IO.File.WriteAllTextAsync(fileName, dataString, token);
            }

            return Ok("Files Created!!!");
        }
    }
}