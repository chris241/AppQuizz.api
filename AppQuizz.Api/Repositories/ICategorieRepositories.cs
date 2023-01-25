using AppQuizz.Api.Models;
using System.Linq.Expressions;

namespace AppQuizz.Api.Repositories
{
    public interface ICategorieRepositories
    {
        void Insert(Categories entity);
        Task UpdateAsync(string id, Categories entity);
        Task DeleteByIdAsync(string id);
        Task DeleteAsync(Quizz entity);
        Task<Categories> GetById(string id);
        Task<List<Categories>> GetAll();
    }
}
