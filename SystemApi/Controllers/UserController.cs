using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SystemApi.SystemDAL.Models;
using SystemApi.SystemDAL.Repos.UserRepo;

namespace SystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserRepo userRepo;

        public UserController(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }
        [HttpGet("{page}/{countPerPage}")]
        public ActionResult<List<User>>? GetAllPerPage(int page, int countPerPage)
        {
            if (page <= 0 || countPerPage <= 0)
                return BadRequest();
            var users = userRepo.GetAllUserPosts(page, countPerPage);
            if (users == null)
                return NoContent();
            return users;
        }
    }
}
