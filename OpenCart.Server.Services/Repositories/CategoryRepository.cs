using Microsoft.EntityFrameworkCore;
using OpenCart.Server.Entity.Data;
using OpenCart.Server.Services.Dto;
using OpenCart.Server.Services.Types;

namespace OpenCart.Server.Services.Repositories;

public class CategoryRepository(ApplicationDbContext db): ICategoryRepository
    {
    public async Task<Result<CategoryViewDto?>> GetByIdAsync(int id)
        {
        var category = await db.Categories.FirstOrDefaultAsync(c => c.Id == id);
        if(category is null)
            {
            return new Result<CategoryViewDto?>() { Success = false,Message = "Category Not Found" };
            }

        return new Result<CategoryViewDto?>()
            {
            Success = true,
            Data = new CategoryViewDto()
                {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                }
            };
        }
    }