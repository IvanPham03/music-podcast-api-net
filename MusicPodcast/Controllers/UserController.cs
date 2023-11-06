using MusicPodcast.Data;
using Microsoft.AspNetCore.Mvc;


namespace MusicPodcast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MusicPodcastDbContext _context;
        public UserController(MusicPodcastDbContext _context)
        {
            this._context = _context;
        }
        [HttpGet]
        public IActionResult GetAllUser()
        {
            return Ok(_context.User.ToList());
        }
    }
}
