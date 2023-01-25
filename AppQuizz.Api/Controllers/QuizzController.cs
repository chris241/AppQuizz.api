

using Microsoft.AspNetCore.Mvc;

namespace AppQuizz.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuizzController : ControllerBase
    {
        public QuizzController()
        {

        }
        [HttpGet]
        public List<Quizz> GetListQuizz()
        {
            return 
        }
    }
}
