using AppQuizz.Api.Models;

namespace AppQuizz.Api.Repositories
{
    public interface IComponentTypeRepositories
    {
        void Insert(ComponentType entity);
        Task UpdateAsync(string id, ComponentType entity);
        Task DeleteByIdAsync(string id);
        Task DeleteAsync(ComponentType entity);
        Task<ComponentType> GetById(string id);
    }
}
