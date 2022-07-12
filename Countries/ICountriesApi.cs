using Countries.Dtos;
using RestEase;

namespace Countries
{
    public interface ICountriesApi
    {
        [Get]
        Task<List<Country>> GetAllCountries();
    }
}