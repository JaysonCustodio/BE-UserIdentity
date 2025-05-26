using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class IdentitiesController : ControllerBase
{
    private readonly AppDbContext _context;

    public IdentitiesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetIdentity(int id)
    {
        var identity = await _context.UserIdentities.FindAsync(id);
        if (identity == null) return NotFound();

        return Ok(identity);
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateIdentity(int id, [FromBody] Dictionary<string, object> updates)
    {
        var identity = await _context.UserIdentities.FindAsync(id);
        if (identity == null) return NotFound();

        foreach (var update in updates)
        {
            var key = update.Key.ToLower();
            var value = update.Value;

            if (value is JsonElement jsonElement)
            {
                switch (key)
                {
                    case "fullname":
                        identity.FullName = jsonElement.GetString();
                        break;

                    case "email":
                        identity.Email = jsonElement.GetString();
                        break;

                    case "sourcesystem":
                        identity.SourceSystem = jsonElement.GetString();
                        break;

                    case "isactive":
                        identity.IsActive = jsonElement.GetBoolean();
                        break;
                }
            }
        }

        identity.LastUpdated = DateTime.UtcNow;
        await _context.SaveChangesAsync();

        return Ok(identity);
    }


}
