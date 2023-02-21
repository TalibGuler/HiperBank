using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GercekMusteriController : ControllerBase
    {
        IGercekMusteriService _gercekMusteriService;
        public GercekMusteriController(IGercekMusteriService gercekMusteriService)
        {
            _gercekMusteriService = gercekMusteriService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _gercekMusteriService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetAll(int id)
        {
            var result = _gercekMusteriService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(GercekMusteri gercekMusteri)
        {
            var result = _gercekMusteriService.Add(gercekMusteri);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Delete(GercekMusteri gercekMusteri)
        {
            var result = _gercekMusteriService.Delete(gercekMusteri);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(GercekMusteri gercekMusteri)
        {
            var result = _gercekMusteriService.Update(gercekMusteri);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

    }
}
