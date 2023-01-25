using AppQuizz.Api.Configurations;
using AppQuizz.Api.Models;
using MongoDB.Driver;

namespace AppQuizz.Api.Repositories
{
    public class QuestionRepositories : IQuestionRepositories
    {
        private readonly IMongoCollection<Questions> collection;
        public QuestionRepositories(QuizzContextDB local)
        {
            collection = local.QuestionContext;
        }

        public Task DeleteAsync(Questions entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Questions>> GetAll()
        {
            return await collection.Find(_=>true).ToListAsync();
        }

        public Task<Questions> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Questions>> GetByIdQuizz(string idQuizz)
        {
            return await collection.Find(x => x.QuizzId == idQuizz).ToListAsync();
        }

        public void Insert(Questions entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, Questions entity)
        {
            throw new NotImplementedException();
        }
    }
}
