using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMealDishes;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("api/mealdishes")]
    public class MealDishesController : ControllerBase
    {

        private readonly IMealDishesService _mealdishesService;

        public MealDishesController(IMealDishesService mealdishesService)
        {
            _mealdishesService = mealdishesService;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var mealdishes = _mealdishesService.GetById(id);

            if (mealdishes == null)
                return NotFound();

            return Ok(mealdishes);
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var mealdishess = _mealdishesService.GetAll();
            return Ok(mealdishess);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] MealDishes model)
        {
            _mealdishesService.Insert(model);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] MealDishes model)
        {
            _mealdishesService.Update(model);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] MealDishes model)
        {
            _mealdishesService.Delete(model);
            return Ok();
        }

    }
}