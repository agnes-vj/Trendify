using Backend.Models;
using Backend.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Authorize]
    [ApiController]
    [Route("{controller}")]
    public class OutfitCalendarController : ControllerBase
    {
        private readonly IOutfitCalendarRepository _repository;
        public OutfitCalendarController(IOutfitCalendarRepository repo)
        {
            _repository = repo;
        }

        [HttpGet]
        public IActionResult GetOutfitCalendarEntries()
        {
            try
            {
                var entries = _repository.GetOutfitCalendarEntries();
                return Ok(entries);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Try again later!");
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetOutfitCalendarEntry(int id)
        {
            try
            {
                var entry = _repository.GetOutfitCalendarEntry(id);
                return Ok(entry);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Try again later!");
            }
        }
        [HttpPost]
        public IActionResult PostOutfitCalendarEntries([FromBody] OutfitCalendarEntry calendarEntry)
        {
            try
            {
                _repository.SaveOutfitCalendarEntry(calendarEntry);
                return Ok(calendarEntry);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error. Try again later!");
            }

        }

    }
}
