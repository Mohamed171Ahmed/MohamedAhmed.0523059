namespace MohamedAhmed._0523059.Repository.Interface
{
    public interface IgenaricRepo<T> where T : class
    {
        Task<IEnumerable<T>> Get();

        Task<T> GetById(int id);

        Task Create(T entity);
        void Update(T entity);
        void Delete(T entity);

        void savechanges();

    }
}
