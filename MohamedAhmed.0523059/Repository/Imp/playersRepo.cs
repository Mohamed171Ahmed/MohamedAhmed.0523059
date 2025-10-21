using MohamedAhmed._0523059.Data;
using MohamedAhmed._0523059.Data.Models;
using MohamedAhmed._0523059.Repository.Interface;

namespace MohamedAhmed._0523059.Repository.Imp
{
    public class playersRepo : GenaricRepo<Player>, IPlayersRepo
    {
        private readonly AppDbContext _appDbContext;
        public playersRepo(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }
    }
}
