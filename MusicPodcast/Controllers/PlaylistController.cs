using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicPodcast.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicPodcast.Controllers
{
    [Route("api/[controller]")]
    public class PlaylistController : Controller
    {
        private IPlaylistRepository _playlistRepository;

        public PlaylistController(IPlaylistRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetPlayList(string id)
        {
            try
            {
                if (id != null)
                {
                    return Ok(await _playlistRepository.GetPlaylistAsync(id));
                }
                return NotFound();

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}

