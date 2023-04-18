using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IOwnerRepository
    {
       ICollection<Owner> GetOwners();
         
        bool OwnerExists(int ownerId);

        Owner GetOwner(int ownerId);

        Owner GetOwnerByName(string  ownerName);


        Country GetOwnerCountry(int ownerId);

        ICollection<PokemonOwner> PokemonOwners(int ownerId);

       ICollection<Owner> GetOwnerOfPokemon(int pokeId);
    }
}
