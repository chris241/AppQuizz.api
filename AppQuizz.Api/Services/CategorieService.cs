using AppQuizz.Api.Models;
using AppQuizz.Api.Models.Views;
using AppQuizz.Api.Repositories;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AppQuizz.Api.Services
{
    public class CategorieService : ICategorieService
    {
        private ICategorieRepositories CategorieRepositories;
        public CategorieService(ICategorieRepositories categorieRepositories)
        {
            CategorieRepositories = categorieRepositories;
        }

        public void InsertOneCategorie(CategoriesView entity)
        {

            try
            {
                var newCat = MapCategories(entity);
                 CategorieRepositories.Insert(newCat);
            }
            catch
            {
            }
        }
        public async Task<List<CategoriesView>> GetListCategorie()
        {

            try
            {
               var categories = await  CategorieRepositories.GetAll();
                return MapCategoriesVL(categories);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private Categories MapCategories(CategoriesView entity)
        {
            return new Categories()
            {
                Name = entity.Name,
                Created = DateTime.Now
            };
        }
        private List<CategoriesView> MapCategoriesVL(List<Categories> entities)
        {
            var newListCategorie = new List<CategoriesView>();

            foreach(var category in entities)
            {
               var categorieView =  new CategoriesView()
                {
                    Id = category.Id,
                    Name = category.Name,
                };
                newListCategorie.Add(categorieView);    

            }
            return newListCategorie;
        }
    }
}
