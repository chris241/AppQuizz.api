using AppQuizz.Api.Configurations;
using AppQuizz.Api.Models;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace AppQuizz.Api.Repositories
{
    public class QuizzRepositories : IQuizzRepositories
    {
        private readonly IMongoCollection<Quizz> collection;
        public QuizzRepositories(QuizzContextDB local)
        {
            collection = local.QuizzContext;
        }
        public Task DeleteAsync(Quizz entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Quizz>> GetAll()
        {
            return await collection.Find(_ => true).ToListAsync();
        }

        public Task<Quizz> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Quizz entity)
        {
            collection.InsertOne(entity);
        }

        public List<Quizz> SearchFor(Expression<Func<Quizz, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, Quizz entity)
        {
            throw new NotImplementedException();
        }
    }
}
