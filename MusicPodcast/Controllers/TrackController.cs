using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicPodcast.Models;
using MusicPodcast.Data;
using MusicPodcast.Services.utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


// api cho song "/track"
namespace MusicPodcast.Controllers
{
    [Route("api/[controller]")]
    public class TrackController : Controller
    {
        private readonly MusicPodcastDbContext _context; // Đối tượng DbContext để truy cập cơ sở dữ liệu

        public TrackController(MusicPodcastDbContext context)
        {
            _context = context;
        }

        // GET: 
        [HttpGet] //  URL mà controller này sẽ xử lý
        public IActionResult GetTracks([FromQuery] int limit = 25) // Tham số limit được đánh dấu bằng [FromQuery] để lấy giá trị từ tham số truy vấn trong URL. Mặc định, giá trị là 25.
        {
            try
            {
                // Sử dụng Entity Framework để lấy danh sách các bài hát từ cơ sở dữ liệu
                var tracks = _context.Track
                    .Take(limit) // Lấy giới hạn số lượng bài hát
                    .ToList();

                // Kiểm tra xem có dữ liệu trả về không
                if (tracks.Count == 0)
                {
                    return NotFound(); // Trả về HTTP Status Code 404 nếu không có dữ liệu
                }

                return Json(tracks); // Trả về danh sách bài hát với HTTP Status Code 200 (OK)
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                // Xử lý lỗi và trả về lỗi 500 (InternalServerError) nếu cần
                return StatusCode(500, "Lỗi trong quá trình xử lý yêu cầu." + ex);
            }
        }
        [HttpGet("{id}")] //  URL mà controller này sẽ xử lý
        public async Task<ActionResult<Track>> GetTrack(string id) // Tham số limit được đánh dấu bằng [FromQuery] để lấy giá trị từ tham số truy vấn trong URL. Mặc định, giá trị là 25.
        {
            try
            {
                // Sử dụng Entity Framework để lấy danh sách các bài hát từ cơ sở dữ liệu
                var track = await _context.Track!.FindAsync(id);

                if (track == null)
                {
                    return NotFound();
                }
                return track;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                // Xử lý lỗi và trả về lỗi 500 (InternalServerError) nếu cần
                return StatusCode(500, "Lỗi trong quá trình xử lý yêu cầu." + ex);
            }
        }
        // POST
        [HttpPost]
        public async Task<ActionResult<Track>> Post([FromBody] Track track)
        {
            var idGenerator = new IdAutoGenerate();
            string id = idGenerator.GenerateId("track");
            _context.Track!.Add(track);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTrack), new { id = track.ID }, track);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

