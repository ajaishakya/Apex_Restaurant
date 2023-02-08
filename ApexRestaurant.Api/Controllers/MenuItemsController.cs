using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMenuItems;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("api/menuitems")]
    public class MenuItemsController : ControllerBase
    {

        private readonly IMenuItemsService _menuitemsService;

        public MenuItemsController(IMenuItemsService customerService)
        {
            _menuitemsService = customerService;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var menuitems = _menuitemsService.GetById(id);

            if (menuitems == null)
                return NotFound();

            return Ok(menuitems);
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var menuitemss = _menuitemsService.GetAll();
            return Ok(menuitemss);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] MenuItems model)
        {
            _menuitemsService.Insert(model);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] MenuItems model)
        {
            _menuitemsService.Update(model);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] MenuItems model)
        {
            _menuitemsService.Delete(model);
            return Ok();
        }

    }
}