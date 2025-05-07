using Microsoft.AspNetCore.Mvc;

namespace OpenCart.Server.Services.Types;
public class Result<TData>
    {
    public bool Success { get; set; } = true;
    public string? Message { get; set; }
    public List<string> Errors { get; set; } = new();
    public TData Data { get; set; }

    public IActionResult ToActionResult()
        {
        if(Success)
            return new OkObjectResult(this);

        return Errors.Any() ? new BadRequestObjectResult(this) : new NotFoundObjectResult(this);
        }
    }
