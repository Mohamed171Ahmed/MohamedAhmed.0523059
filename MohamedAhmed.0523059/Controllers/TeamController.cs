using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MohamedAhmed._0523059.Data.Models;
using MohamedAhmed._0523059.Dtos;
using MohamedAhmed._0523059.Repository.Interface;

namespace MohamedAhmed._0523059.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IteamRepo _teamRepo;

        public TeamController(IteamRepo teamRepo)
        {
            _teamRepo = teamRepo;
        }

        public async Task<IActionResult> PostTeam(TeamDto teamDto, CoachDto coachDto)
        {
            var team = new Team()
            {
                Id = teamDto.Id,
                Name = teamDto.Name,
                City = teamDto.City,
               

            };
            return Ok(team);
        }
    }
}
