using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly AppDbContext _context;
        public OwnerRepository(AppDbContext context)
        {
            _context = context;
        }
        public Owner GetOwner(int ownerId)
        {
            return _context.Owners.Where(o => o.Id == ownerId).FirstOrDefault();
        }

        public Owner GetOwnerByName(string ownerName)
        {
            return _context.Owners.Where(o => o.FirstName == ownerName).FirstOrDefault();
        }

        public Country GetOwnerCountry(int ownerId)
        {
            return _context.Owners.Where(o => o.Id == ownerId).Select(c => c.Country).FirstOrDefault();
        }

        public ICollection<Owner> GetOwners()
        {
           return _context.Owners.OrderBy(o =>o.Id).ToList();
        }

        public bool OwnerExists(int ownerId)
        {
            return _context.Owners.Any(o => o.Id == ownerId);
        }

        public ICollection<PokemonOwner> PokemonOwners(int ownerId)
        {
           return _context.Owners.Where(o => o.Id != ownerId).Select(p => p.PokemonOwners).FirstOrDefault();
        }

        ICollection<Owner> IOwnerRepository.GetOwnerOfPokemon(int pokeId)
        {
            throw new NotImplementedException();
        }
    }

}
