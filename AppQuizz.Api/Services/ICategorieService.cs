using AppQuizz.Api.Models.Views;

namespace AppQuizz.Api.Services
{
    public interface ICategorieService
    {
        void InsertOneCategorie(CategoriesView entity);
        Task<List<CategoriesView>> GetListCategorie();
    }
}
