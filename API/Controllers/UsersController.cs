using Microsoft.AspNetCore.Mvc;
using API.entities;
using API.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public UsersController(DataContext dataContext)
        {
            _dataContext = dataContext;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _dataContext.Users.ToListAsync();
        }
        //[HttpGet("{username}")]
        // public ActionResult<AppUser> GetUsers(string username)
        // {
        //      return _dataContext.Users.SingleOrDefault(u=>u.UserName==username);
            
        // }
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id)
        {
           return await _dataContext.Users.FindAsync(id);
        }
    }

}