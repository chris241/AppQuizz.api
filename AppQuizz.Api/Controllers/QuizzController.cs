

using AppQuizz.Api.Models.Views;
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
        public List<QuizzViewList> GetListQuizz()
        {
            return new List<QuizzViewList>();   
        }
    }
}
