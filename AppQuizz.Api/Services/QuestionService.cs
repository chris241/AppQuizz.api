using AppQuizz.Api.Models;
using AppQuizz.Api.Models.Views;
using AppQuizz.Api.Repositories;

namespace AppQuizz.Api.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepositories _questionRepositories;
        private readonly IAnswerRepositories _answerRepositories;
        private readonly IComponentTypeRepositories _componentTypeRepositories;
        public QuestionService(
            IQuestionRepositories questionRepositories,
            IAnswerRepositories answerRepositories,
            IComponentTypeRepositories componentTypeRepositories
            )
        {
            _questionRepositories = questionRepositories;
            _answerRepositories = answerRepositories;
            _componentTypeRepositories = componentTypeRepositories; 
        }

        public void AddQuestion(QuestionView questionView)
        {
            var quest = this.MapQuestion(questionView);
            _questionRepositories.Insert(quest);
        }
        public void AddComponentType(ComponentTypeView componentTypeView)
        {
            var componentType = this.MapCompo(componentTypeView);
            _componentTypeRepositories.Insert(componentType);
        }
        public void AddAnswer(AnswerView answerView)
        {
            var answer = this.MapAnswer(answerView);
            _answerRepositories.Insert(answer); ;
        }
        private Questions MapQuestion(QuestionView questionView)
        {
            return new Questions()
            {
                Title = questionView.Title,
                CountResponse = questionView.CountResponse,
                QuizzId = questionView.QuizzId,
                ComponentId = questionView.ComponentId,
                Created = DateTime.Now
            };
        }
        private ComponentType MapCompo(ComponentTypeView view)
        {
            return new ComponentType()
            {
                Name = view.Name,
                Created = DateTime.Now
            };
        }
        private Answers MapAnswer(AnswerView answerView)
        {
            return new Answers()
            {
                Value = answerView.Value,
                QuestionId = answerView.QuestionId,
                IsExact = answerView.IsExact,
                Created = DateTime.Now
            };
        }


    }
}
