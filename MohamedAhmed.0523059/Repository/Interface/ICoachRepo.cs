using MohamedAhmed._0523059.Data.Models;

namespace MohamedAhmed._0523059.Repository.Interface
{
    public interface ICoachRepo : IgenaricRepo<Coach>
    {
        public Task<Coach> GetById(int id);
    }
}
