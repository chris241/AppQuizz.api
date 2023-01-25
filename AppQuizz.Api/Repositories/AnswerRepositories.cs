using AppQuizz.Api.Configurations;
using AppQuizz.Api.Models;
using MongoDB.Driver;

namespace AppQuizz.Api.Repositories
{
    public class AnswerRepositories : IAnswerRepositories
    {
        private readonly IMongoCollection<Answers> collection; 
        public AnswerRepositories(QuizzContextDB location)
        {
            collection = location.AnswerContext;
        }
        public Task DeleteAsync(Answers entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Answers> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Answers>> GetByQuestionId(string questionId)
        {
           return await collection.Find(x => x.QuestionId == questionId).ToListAsync();
        }

        public void Insert(Answers entity)
        {
            collection.InsertOne(entity);
        }

        public Task UpdateAsync(string id, Answers entity)
        {
            throw new NotImplementedException();
        }
    }
}
