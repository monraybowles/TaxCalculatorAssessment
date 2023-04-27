using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserTaxCalculationsController : ControllerBase
    {
        IUserTaxCalculationService _userTaxCalculationsService;

        public UserTaxCalculationsController(IUserTaxCalculationService userTaxCalculationsService)
        {
            _userTaxCalculationsService = userTaxCalculationsService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _userTaxCalculationsService.GetAll();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult Get(Guid id)
        {
            var result = _userTaxCalculationsService.GetById(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(UserTaxCalculation UserTaxCalculations)
        {
            var result = _userTaxCalculationsService.Add(UserTaxCalculations);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(UserTaxCalculation UserTaxCalculations)
        {

            var result = _userTaxCalculationsService.Delete(UserTaxCalculations);
            return result.Success ? Ok(result) : BadRequest(result);

        }

        [HttpPut("update")]
        public IActionResult Update(UserTaxCalculation UserTaxCalculations)
        {

            var result = _userTaxCalculationsService.Update(UserTaxCalculations);
            return result.Success ? Ok(result) : BadRequest(result);

        }
    }
}
