using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        bool CountryExist(int countryId);

        Country GetCountry (int countryId);

        ICollection<Country> GetCountries();

        Country GetCountryByOwner(int ownerId);
    }
}
