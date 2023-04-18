using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();

        bool ReviewExists(int reviewId);

        Review GetReview(int reviewId);
        Pokemon GetPokemonReview(int reviewId);
        Reviewer GetReviewReviewer(int reviewId);

        
    }
}

