using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SchoolSystem.Services.Abstraction;
using SchoolSystem.Models.Models.StudentClass;

namespace SchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentClassController : ControllerBase
    {
        private readonly IStudentClassService _service;

        public StudentClassController(IStudentClassService service)
        {
            _service = service;
        }



        [HttpGet("ByClass/{id:int}", Name = nameof(GetByClass))]
        public async Task<IActionResult> GetByClass([FromRoute] int id)
        {
            var option = await _service.GetByClassId(id);
            return option != null ? Ok(option) : NoContent();
        }

        [HttpGet("ByStudent/{id:int}", Name = nameof(GetByStudent))]
        public async Task<IActionResult> GetByStudent([FromRoute] int id)
        {
            var option = await _service.GetByStudentId(id);
            return option != null ? Ok(option) : NoContent();
        }


        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody] StudentClassCreateModel model)
        {
            if (ModelState.IsValid)
            {
                var item = await _service.Insert(model);
                if (item != null)
                {
                    return CreatedAtRoute(nameof(GetByClass), item, item.Id);
                }

                return Conflict();
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] StudentClassUpdateModel model)
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

