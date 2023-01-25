using AppQuizz.Api.Models.Views;
using AppQuizz.Api.Services;
using Microsoft.AspNetCore.Mvc;


namespace AppQuizz.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategorieService _categorieService;
        public CategoriesController(ICategorieService categorieService)
        {
            _categorieService = categorieService;   
        }
        [HttpPost]
        public ActionResult CreateCategorie([FromBody]CategoriesView categorie)
        {
            try
            {
                _categorieService.InsertOneCategorie(categorie);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
           
        }
        [HttpGet]
        public async  Task<List<CategoriesView>> ListCategorie()
        {

                return await _categorieService.GetListCategorie();


        }
    }
}
