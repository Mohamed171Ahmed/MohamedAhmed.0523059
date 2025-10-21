using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MohamedAhmed._0523059.Dtos;
using MohamedAhmed._0523059.Repository.Interface;

namespace MohamedAhmed._0523059.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {

        private readonly IPlayersRepo _playersRepo;

        public PlayersController(IPlayersRepo playersRepo)
        {
            _playersRepo = playersRepo;
        }


        [HttpPut]

        public async Task<IActionResult> UpdatePlayer(int id, PlayerDto playerDto)
        {
            var p = await _playersRepo.GetById(id);

            p.FullName = playerDto.FullName;
            p.Postion = playerDto.Postion;
            p.Age = playerDto.Age;

             _playersRepo.Update(p);
             _playersRepo.savechanges();

            return Ok(p);


        }
    }
}
