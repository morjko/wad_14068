using Microsoft.AspNetCore.Mvc;
using ContactManager_14068_DAL.Models;
using ContactManager_14068_DAL.Repositories;

namespace ContactManager_14068.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupsRepository _groupsRepository;

        public GroupsController(IGroupsRepository groupsRepository)
        {
            _groupsRepository = groupsRepository;
        }

        // GET: api/Groups
        [HttpGet]
        public async Task<IEnumerable<Group>> GetGroups()
        {
            return await _groupsRepository.GetAll();
        }

        // GET: api/Groups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Group>> GetGroup(int id)
        {
            var group = await _groupsRepository.GetGroup(id);

            if (group == null)
            {
                return NotFound();
            }

            return Ok(group);
        }

        // PUT: api/Groups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroup(int id, Group group)
        {
            if (id != group.Id)
            {
                return BadRequest();
            }

            await _groupsRepository.UpdateGroup(group);
            
            return NoContent();
        }

        // POST: api/Groups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Group>> PostGroup(Group group)
        {
            await _groupsRepository.CreateGroup(group);

            return CreatedAtAction("GetGroup", new { id = @group.Id }, @group);
        }

        // DELETE: api/Groups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGroup(int id)
        {
            await _groupsRepository.DeleteGroup(id);

            return NoContent();
        }
    }
}
