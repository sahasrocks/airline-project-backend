using Class18projectrialDbfirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class18projectrialDbfirst.UsrRepo
{
    public interface IUsrRepo
    {
        Task<ActionResult<IEnumerable<User>>> GetUsers();
        Task<ActionResult<User>> PostUsers(User user);
        Task<ActionResult<User>> PutUsers(User user);
        Task<ActionResult<User>> DeleteUsers(string id);
    }
}
