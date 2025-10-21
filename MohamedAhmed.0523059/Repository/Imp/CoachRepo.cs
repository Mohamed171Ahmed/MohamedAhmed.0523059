using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using MohamedAhmed._0523059.Data;
using MohamedAhmed._0523059.Data.Models;
using MohamedAhmed._0523059.Repository.Interface;

namespace MohamedAhmed._0523059.Repository.Imp
{
    public class CoachRepo : GenaricRepo<Coach>, ICoachRepo
    {
        private readonly AppDbContext _appDbContext;

        public CoachRepo(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }


        public async Task<IEnumerable<Coach>> GetById(int id)
        {
           return await _appDbContext.coaches.Include(x => x.team).ThenInclude(x => x.Players).ToListAsync();
            
            
        } 








    }
}
