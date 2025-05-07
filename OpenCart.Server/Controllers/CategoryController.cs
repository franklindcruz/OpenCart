using Microsoft.AspNetCore.Mvc;
using OpenCart.Server.Services.Dto;
using OpenCart.Server.Services.Repositories;

namespace OpenCart.Server.Controllers;


[ApiController]
[Route("[controller]")]
public class CategoryController(ICategoryRepository categoryRepository): ControllerBase
    {
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(CategoryViewDto),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int id)
        {
        var result = await categoryRepository.GetByIdAsync(id);
        return result is null ? NotFound() : Ok(result);
        }
    }
