using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SchoolSystem.Services.Abstraction;
using SchoolSystem.Models.Models.Class;

namespace SchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _service;

        public ClassController(IClassService service)
        {
            _service = service;
        }

        [HttpGet("Options/{id:int}", Name = nameof(GetClass))]
        public async Task<IActionResult> GetClass([FromRoute] int id)
        {
            var option = await _service.Get(id);
            return option != null ? Ok(option) : NoContent();
        }

        [HttpGet("Classes")]
        public async Task<IActionResult> Get()
        {
            var options = await _service.Get();
            return options != null && options.Any() ? Ok(options) : NoContent();
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody] ClassCreateModel model)
        {
            if (ModelState.IsValid)
            {
                var item = await _service.Insert(model);
                if (item != null)
                {
                    return CreatedAtRoute(nameof(GetClass), item, item.Id);
                }

                return Conflict();
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] ClassUpdateModel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = id;
                var item = await _service.Update(model);

                return item != null ? Ok(item) : NoContent();
            }

            return BadRequest();
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (ModelState.IsValid)
            {
                Ok(await _service.Delete(id));
            }
            return BadRequest();
        }

    }
}

