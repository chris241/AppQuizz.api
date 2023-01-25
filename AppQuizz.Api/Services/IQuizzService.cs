using AppQuizz.Api.Models;
using AppQuizz.Api.Models.Views;
using System.Linq.Expressions;

namespace AppQuizz.Api.Services
{
    public interface IQuizzService
    {
        Task<List<QuizzViewList>> GetAllQuizzView();
        List<QuizzViewList> SearchForQuizzView(Expression<Func<QuizzViewList, bool>> predicate);
        void AddQuizz(QuizzView quizzView); 
    }
}
