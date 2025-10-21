using MohamedAhmed._0523059.Data;
using MohamedAhmed._0523059.Data.Models;
using MohamedAhmed._0523059.Repository.Interface;

namespace MohamedAhmed._0523059.Repository.Imp
{
    public class TeamRepo : GenaricRepo<Team>, IteamRepo
    {
        private readonly AppDbContext _appDbContext;
        public TeamRepo(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }
    }
}
