namespace Shop.Models.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Save();

    }
}
