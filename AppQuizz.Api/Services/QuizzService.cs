using AppQuizz.Api.Models;
using AppQuizz.Api.Models.Views;
using AppQuizz.Api.Repositories;
using AutoMapper;
using System.Linq.Expressions;

namespace AppQuizz.Api.Services
{
    public class QuizzService: IQuizzService
    {
        private IQuizzRepositories QuizzRepositories;
        private ICategorieRepositories CategorieRepositories;
        public QuizzService(
            IQuizzRepositories quizzRepositories,
            ICategorieRepositories categorieRepositories
            )
        {
            QuizzRepositories = quizzRepositories; 
            CategorieRepositories = categorieRepositories;
        }

        public void AddQuizz(QuizzView quizzView)
        {
            var quizz = this.MapQuizz(quizzView);
            QuizzRepositories.Insert(quizz);
        }

        public async Task<List<QuizzViewList>> GetAllQuizzView()
        {
            var quizzs =  await QuizzRepositories.GetAll();
            var QuizzVL = this.MapQuizzVL(quizzs);
            return QuizzVL;
        }

        public List<QuizzViewList> SearchForQuizzView(Expression<Func<QuizzViewList, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        private List<QuizzViewList> MapQuizzVL(List<Quizz> quizz)
        {
            var newQuizzs =new  List<QuizzViewList>();
            foreach(var quizzItem in quizz)
            {
                var category = CategorieRepositories.GetById(quizzItem.CategorieId!);
                var newQuizz = new QuizzViewList()
                {
                    Id = quizzItem.Id,
                    Title = quizzItem.Title,
                    Score = quizzItem.Score,
                    Categories =  category.Result.Name,

                };
                newQuizzs.Add(newQuizz);
            }
            return newQuizzs;
        }
        private Quizz MapQuizz(QuizzView quizz)
        {
            
            return new Quizz()
            {
                CategorieId = quizz.CategorieId,
                Title = quizz.Title,
                Score = quizz.Score,
                Descriptions = quizz.Descriptions,
                Created = DateTime.Now

            };
        }
    }
}
