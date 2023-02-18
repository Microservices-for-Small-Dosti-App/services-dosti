using Dosti.Data.Entities;
using Dosti.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dosti.Api.Controllers;

public class UsersController : BaseApiController
{
    private readonly DostiDbContext _dostiDbContext;

    public UsersController(DostiDbContext dostiDbContext)
    {
        _dostiDbContext = dostiDbContext ?? throw new ArgumentNullException(nameof(dostiDbContext));
    }

    [HttpGet(Name = "GetUsers")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IReadOnlyCollection<DostiUser>>> GetUsers()
    {
        return await _dostiDbContext.Users.ToListAsync();
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<DostiUser>> GetUserById(Guid id)
    {
        return await _dostiDbContext.Users.FindAsync(id) is DostiUser user ? Ok(user) : NotFound();
    }

}
