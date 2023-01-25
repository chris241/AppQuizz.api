using AppQuizz.Api.Models.Views;
using AppQuizz.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppQuizz.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuestionsController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
         [HttpGet]
         public async Task<List<QuestionViewList>> ListQuestionVL(string quizzId)
         {
            return await _questionService.ListQuestionVLByQuizzId(quizzId);
         }
        [HttpPost]
        public ActionResult CreateQuestion([FromBody] QuestionView questionView)
        {
            try
            {
                _questionService.AddQuestion(questionView);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult CreateComponentType([FromBody] ComponentTypeView componentTypeView)
        {
            try
            {
                _questionService.AddComponentType(componentTypeView);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult CreateAnswer([FromBody] AnswerView answerView)
        {
            try
            {
                _questionService.AddAnswer(answerView);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
