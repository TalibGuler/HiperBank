using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumTuruController : ControllerBase
    {
        IEnumTuruService _enumTuruService;

        public EnumTuruController(IEnumTuruService enumTuruService)
        {
            _enumTuruService = enumTuruService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _enumTuruService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetAll(int id)
        {
            var result = _enumTuruService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(EnumTuru enumTuru)
        {
            var result = _enumTuruService.Add(enumTuru);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(EnumTuru enumTuru)
        {
            var result = _enumTuruService.Delete(enumTuru);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(EnumTuru enumTuru)
        {
            var result = _enumTuruService.Update(enumTuru);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }
    }
}
