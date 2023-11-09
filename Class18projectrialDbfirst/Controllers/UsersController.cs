using Class18projectrialDbfirst.Models;
using Class18projectrialDbfirst.UsrRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class18projectrialDbfirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsrRepo _repository;
        public UsersController(IUsrRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _repository.GetUsers();

        }
        [HttpPost]
        public async Task<ActionResult<User>> PostUsers(User user)
        {
            return await _repository.PostUsers(user);
        }
        [HttpPut]
        public async Task<ActionResult<User>> PutUsers(User user)
        {
            return await _repository.PutUsers(user);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUsers(string id)
        {
            try
            {
                return await _repository.DeleteUsers(id);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
