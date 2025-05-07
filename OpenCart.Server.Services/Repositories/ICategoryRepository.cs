using OpenCart.Server.Services.Dto;
using OpenCart.Server.Services.Types;

namespace OpenCart.Server.Services.Repositories
    {
    public interface ICategoryRepository
        {
        Task<Result<CategoryViewDto?>> GetByIdAsync(int id);
        }
    }