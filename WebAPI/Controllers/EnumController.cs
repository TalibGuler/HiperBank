using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumController : ControllerBase
    {
        IEnumService _enumService;
        public EnumController(IEnumService enumService)
        {
            _enumService = enumService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _enumService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _enumService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Enum _enum)
        {
            var result = _enumService.Add(_enum);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Enum _enum)
        {
            var result = _enumService.Delete(_enum);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Enum _enum)
        {
            var result = _enumService.Update(_enum);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

    }
}
