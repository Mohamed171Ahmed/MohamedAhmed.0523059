using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MohamedAhmed._0523059.Dtos;
using MohamedAhmed._0523059.Repository.Interface;

namespace MohamedAhmed._0523059.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachController : ControllerBase
    {
        private readonly ICoachRepo _coachRepo;

        public CoachController(ICoachRepo coachRepo)
        {
            _coachRepo = coachRepo;
        }


        [HttpGet]
        public async Task<IActionResult> getco(int id)
        {
            var c = await _coachRepo.GetById(id);

            if (c == null) return NotFound();

            var coach1 = new CreateCoachDto()
            {
                Id = c.Id,
                Name = c.Name,
                Specialization = c.Specialization,
                ExperrienceYears = c.ExperrienceYears,
                Teamm = c.team.Name,
                numofPlayers = c.team.Players.Count(),
            }.ToString();





            return Ok(coach1);
        }



       






    }
}
