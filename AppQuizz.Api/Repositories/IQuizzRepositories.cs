using AppQuizz.Api.Models;
using System.Linq.Expressions;

namespace AppQuizz.Api.Repositories
{
    public interface IQuizzRepositories
    {
        void Insert(Quizz entity);
        Task UpdateAsync(string id, Quizz entity);
        Task DeleteByIdAsync(string id);
        Task DeleteAsync(Quizz entity);
        Task<Quizz> GetById(string id);
        Task<List<Quizz>> GetAll();
        List<Quizz> SearchFor(Expression<Func<Quizz, bool>> predicate);
    }
}
