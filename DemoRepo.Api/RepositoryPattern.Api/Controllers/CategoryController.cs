using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Application.EntitiesCQ.Categorys.Interfaces;
using RepositoryPattern.Domain;
using RepositoryPattern.Domain.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _repository;

        public CategoryController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("categories")]
        public IActionResult GetCategories()
        {
            IEnumerable<Category> categories = _repository.GetAll();
            return Ok(categories);
        }

        [HttpGet("category/{id}")]
        public IActionResult Getcategory(int id)
        {
            Category category = _repository.GetById(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost("category")]
        public IActionResult Post([FromBody] CreateCategoryVm categoryVm)
        {
            if (categoryVm == null)
            {
                return BadRequest();
            }

            _repository.Create(categoryVm);

            return Ok(categoryVm);
        }

        [HttpPut("caregory/{id}")]
        public IActionResult Put(int id, [FromBody] UpdateCategoryVm categoryVm)
        {
            if (categoryVm == null)
            {
                return BadRequest();
            }

            if (id != categoryVm.CategoryId)
            {
                return NotFound();
            }

            _repository.Update(categoryVm);
            return Ok(categoryVm);
        }

        [HttpDelete("caregory/{id}")]
        public IActionResult Delete(int id)
        {
            Category category = _repository.GetById(id);

            if (category == null)
            {
                return BadRequest();
            }

            _repository.Delete(category);

            return Ok(category);
        }
    }
}
