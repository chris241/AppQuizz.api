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
        public async Task<List<QuestionViewList>>ListQuestionVLByQuizzId(string quizzId)
        {
            var questionViewList = new List<QuestionViewList>();
           var questions = await _questionRepositories.GetByQuizzId(quizzId);
            foreach(var question in questions)
            {
                var componentType = await _componentTypeRepositories.GetById(question.ComponentId!);
                var answer  = await _answerRepositories.GetByQuestionId(question.Id!);
                questionViewList.Add(MapQuestionViewList(question, componentType, answer));
            }
            return questionViewList;
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
        private QuestionViewList MapQuestionViewList(Questions question, ComponentType componentType,List<Answers> answers)
        {
            return new QuestionViewList()
            {
               CountResponse = question.CountResponse,
               Title = question.Title,
               ComponentName = componentType.Name,
               AnswerViewLists = this.MapAnswerViewLis(answers) 

            };
        }
        private List<AnswerViewList> MapAnswerViewLis(List<Answers> answers)
        {
            var answerList = new List<AnswerViewList>();
            foreach (var answersItem in answers)
            {
                answerList.Add(new AnswerViewList()
                {
                    Id = answersItem.Id,
                    Value = answersItem.Value,
                });
            }
            return answerList;  
        }

    }
}
