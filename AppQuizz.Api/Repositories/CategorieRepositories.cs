using AppQuizz.Api.Configurations;
using AppQuizz.Api.Models;
using MongoDB.Driver;

namespace AppQuizz.Api.Repositories
{
    public class CategorieRepositories : ICategorieRepositories
    {
        private readonly IMongoCollection<Categories> collection;
        public CategorieRepositories(QuizzContextDB local)
        {
            collection = local.CategorieContext;
        }
        public Task DeleteAsync(Quizz entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Categories>> GetAll()
        {
            return await collection.Find(x => true).ToListAsync(); ;
        }

        public Task<Categories> GetById(string id)
        {
            return collection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public void Insert(Categories entity)
        {
            collection.InsertOne(entity);
        }

        public Task UpdateAsync(string id, Categories entity)
        {
            throw new NotImplementedException();
        }
    }
}
