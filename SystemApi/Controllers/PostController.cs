using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SystemApi.SystemDAL.Models;
using SystemApi.SystemDAL.Repos.PostRepo;
using SystemApi.SystemDAL.Repos.UserRepo;

namespace SystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        public readonly IPostRepo repo;

        public PostController(IPostRepo post)
        {
            this.repo = post;
        }
        [HttpPost]
        public ActionResult Add(PostDto post)
        {
            if (post == null)
            {
                return NoContent();
            }
            var postAdded = repo.Add(post);
            if (postAdded != true)
                return BadRequest();
            return Ok();
        }
    }
}
