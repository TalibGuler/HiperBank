using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BilancoController : ControllerBase
    {
        IBilancoService _bilancoService;

        public BilancoController(IBilancoService bilancoService)
        {
            _bilancoService = bilancoService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bilancoService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetAll(int id)
        {
            var result = _bilancoService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Bilanco bilanco)
        {
            var result = _bilancoService.Add(bilanco);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Delete(Bilanco bilanco)
        {
            var result = _bilancoService.Delete(bilanco);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Bilanco bilanco)
        {
            var result = _bilancoService.Update(bilanco);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

    }
}
