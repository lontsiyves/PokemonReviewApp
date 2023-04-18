using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        bool CategoryExists(int  id);
        Category GetCategory(int id);
        Category Category(string name);
        ICollection<Category> GetCategories();
        ICollection<Pokemon> GetPokemonsForCategory(int categoryId);

        bool CreateCategory(Category category);


    }
}
