using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly AppDbContext _context;
        public ReviewRepository(AppDbContext context)
        {
            _context = context;
        }

        public Pokemon GetPokemonReview(int reviewId)
        {
            return _context.Reviews.Where(r => r.Id == reviewId).Select(c => c.Pokemon).FirstOrDefault();
        }

        public Review GetReview(int reviewId)
        {
            return _context.Reviews.Where(c => c.Id == reviewId).FirstOrDefault();
        }

        public Reviewer GetReviewReviewer(int reviewId)
        {
            return _context.Reviews.Where(r => r.Id == reviewId).Select(c => c.Reviewer).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.OrderBy(r => r.Id).ToList();
         }

        public bool ReviewExists(int reviewId)
        {
            return _context.Reviews.Any(r =>r.Id == reviewId);
        }
    }
}
