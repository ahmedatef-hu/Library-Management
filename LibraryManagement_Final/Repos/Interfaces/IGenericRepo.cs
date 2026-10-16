namespace LibraryManagement_Final.Repos.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        Task<ICollection<T>> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);
        void Update(T entity);
        Task Delete(T entity);
    }
}
