using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TuzelMusteriController : ControllerBase
    {
        ITuzelMusteriService _tuzelMusteriService;

        public TuzelMusteriController(ITuzelMusteriService tuzelMusteriService)
        {
            _tuzelMusteriService = tuzelMusteriService;
        }

        //[Produces("application/json", "text/plain")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<MusteriBilancoResponseDto>))]
        //[ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpGet("MusteriBilancoResponseDto")]
        public IActionResult GetMusteriBilancoResponseDto()
        {

            var result = _tuzelMusteriService.GetMusteriBilancoResponseDto();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _tuzelMusteriService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetAll(int id)
        {
            var result = _tuzelMusteriService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpPut("add")]
        public IActionResult Add(TuzelMusteri tuzelMusteri)
        {

            var result = _tuzelMusteriService.Add(tuzelMusteri);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Delete(TuzelMusteri tuzelMusteri)
        {
            var result = _tuzelMusteriService.Delete(tuzelMusteri);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(TuzelMusteri tuzelMusteri)
        {
            var result = _tuzelMusteriService.Update(tuzelMusteri);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }
    }
}
