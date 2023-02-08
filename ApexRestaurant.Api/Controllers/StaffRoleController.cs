using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SStaffRole;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("api/staffrole")]
    public class StaffRoleController : ControllerBase
    {

        private readonly IStaffRoleService _staffroleService;

        public StaffRoleController(IStaffRoleService staffroleService)
        {
            _staffroleService = staffroleService;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var staffrole = _staffroleService.GetById(id);

            if (staffrole == null)
                return NotFound();

            return Ok(staffrole);
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var staffroles = _staffroleService.GetAll();
            return Ok(staffroles);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] StaffRole model)
        {
            _staffroleService.Insert(model);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] StaffRole model)
        {
            _staffroleService.Update(model);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] StaffRole model)
        {
            _staffroleService.Delete(model);
            return Ok();
        }

    }
}