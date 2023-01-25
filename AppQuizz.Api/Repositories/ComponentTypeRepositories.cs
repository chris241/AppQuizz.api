using AppQuizz.Api.Configurations;
using AppQuizz.Api.Models;
using MongoDB.Driver;

namespace AppQuizz.Api.Repositories
{
    public class ComponentTypeRepositories : IComponentTypeRepositories
    {
        private readonly IMongoCollection<ComponentType> collection;
        public ComponentTypeRepositories(QuizzContextDB local)
        {
            collection = local.ComponentTypeContext;
        }
        public Task DeleteAsync(ComponentType entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ComponentType> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(ComponentType entity)
        {
            collection.InsertOne(entity);
        }

        public Task UpdateAsync(string id, ComponentType entity)
        {
            throw new NotImplementedException();
        }
    }
}
