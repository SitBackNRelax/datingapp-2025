using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")] // localhost:5001/api/members
    [ApiController]
    public class MembersController(AppDbContext Context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AppUser>>> GetMembers()
        {
            var members = await Context.Users.ToListAsync();

            return members;
        }

        [HttpGet("{id}")] // localhost:5001/api/members/bob-id
        public async Task<ActionResult<AppUser>> GetMembers(string id)
        {
            var member = await Context.Users.FindAsync(id);

            if (member == null) return NotFound();

            return member;
        }
    }
}
