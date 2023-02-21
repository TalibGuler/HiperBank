using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusteriKayitKanaliController : ControllerBase
    {
        IMusteriKayitKanaliService _musteriKayitKanaliService;

        public MusteriKayitKanaliController(IMusteriKayitKanaliService musteriKayitKanaliService)
        {
            _musteriKayitKanaliService = musteriKayitKanaliService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _musteriKayitKanaliService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetAll(int id)
        {
            var result = _musteriKayitKanaliService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(MusteriKayitKanali musteriKayitKanali)
        {
            var result = _musteriKayitKanaliService.Add(musteriKayitKanali);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Delete(MusteriKayitKanali musteriKayitKanali)
        {
            var result = _musteriKayitKanaliService.Delete(musteriKayitKanali);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(MusteriKayitKanali musteriKayitKanali)
        {
            var result = _musteriKayitKanaliService.Update(musteriKayitKanali);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }


        //[Produces("application/json", "text/plain")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<MusteriBilancoResponseDto>))]
        //[ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpGet("GetMusteriKayitKanaliResponseDto")]
        public IActionResult GetMusteriKayitKanaliResponseDto()
        {

            var result = _musteriKayitKanaliService.GetMusteriKayitKanaliResponseDto();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
    }
}
