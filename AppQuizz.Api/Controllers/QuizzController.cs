

using AppQuizz.Api.Models.Views;
using AppQuizz.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppQuizz.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuizzController : ControllerBase
    {
        private IQuizzService QuizzService;
        public QuizzController(IQuizzService quizzService)
        {
            QuizzService = quizzService;
        }
        [HttpGet]
        public async Task<List<QuizzViewList>> GetListQuizz()
        {
            return await QuizzService.GetAllQuizzView();
        }
        [HttpPost]
        public ActionResult CreateQuizz([FromBody] QuizzView quizzView)
        {
            try
            {
                QuizzService.AddQuizz(quizzView);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }

        }
    }
}
