using AppQuizz.Api.Models;

namespace AppQuizz.Api.Repositories
{
    public interface IAnswerRepositories
    {
        void Insert(Answers entity);
        Task UpdateAsync(string id, Answers entity);
        Task DeleteByIdAsync(string id);
        Task DeleteAsync(Answers entity);
        Task<Answers> GetById(string id);
        Task<List<Answers>> GetByQuestionId(string questionId);
    }
}
