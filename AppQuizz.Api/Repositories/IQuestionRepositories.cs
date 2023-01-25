using AppQuizz.Api.Models;

namespace AppQuizz.Api.Repositories
{
    public interface IQuestionRepositories
    {
        void Insert(Questions entity);
        Task UpdateAsync(string id, Questions entity);
        Task DeleteByIdAsync(string id);
        Task DeleteAsync(Questions entity);
        Task<Questions> GetById(string id);
        Task<List<Questions>> GetByQuizzId(string quizzId);
        Task<List<Questions>> GetAll();
    }
}
