
using AppQuizz.Api.Models.Views;

namespace AppQuizz.Api.Services
{
    public interface IQuestionService
    {
        void AddQuestion(QuestionView questionView);
        void AddComponentType(ComponentTypeView questionView);
        void AddAnswer(AnswerView answerView);
        Task<List<QuestionViewList>> ListQuestionVLByQuizzId(string quizzId);
    }
}
