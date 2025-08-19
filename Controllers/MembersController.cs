using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    
    public class MembersController(AppDbContext Context) : BaseAPIController
    {
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AppUser>>> GetMembers()
        {
            var members = await Context.Users.ToListAsync();

            return members;
        }

        [Authorize]
        [HttpGet("{id}")] // localhost:5001/api/members/bob-id
        public async Task<ActionResult<AppUser>> GetMembers(string id)
        {
            var member = await Context.Users.FindAsync(id);

            if (member == null) return NotFound();

            return member;
        }
    }
}
